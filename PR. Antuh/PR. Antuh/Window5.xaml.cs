using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR.Antuh
{
	/// <summary>
	/// Логика взаимодействия для Window5.xaml
	/// </summary>
	public static class ArrExtension
	{
		public static DataTable ToDataTable(int[,] array)
		{
			var res = new DataTable();

			for (int j = 0; j < array.GetLength(1); j++)
			{
				res.Columns.Add("col" + j);
			}

			for (int i = 0; i < array.GetLength(0); i++)
			{
				var row = res.NewRow();

				for (int j = 0; j < array.GetLength(1); j++)
				{
					row[j] = array[i, j];
				}

				res.Rows.Add(row);
			}

			return res;
		}
	}
	public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			int N, M;
			if (int.TryParse(tb_a.Text, out N) && int.TryParse(tb_b.Text, out M))
			{
				int[,] mas = new int[N, M];
				Random rnd = new Random();

				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < M; j++)
					{
						mas[i, j] = rnd.Next(-10, 10);
					}
				}
				data_one_mas.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
				//Сортировка массива
				int[] m = new int[N * M];

				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < M; j++)
					{
						m[j + i * M] = mas[i, j];// из двумерного в одномерный
					}
				}
				int min = m.Min();
				int max = m.Max(); 
				lb_max.Content = max;
				lb_min.Content = min;

				void Preobraz(int[] arr)
				{
					int i = 0;
					while (i < N)
					{
						for (int j = 0; j < M; j++)
						{
							mas[i, j] = arr[j + i * M];//вычисляем индекс одномерого массива 012345 , по индексу записываем в двумерный.
						}
						i++;
					}
				}
				
				BubbleSort(m);
				Preobraz(m);
				data_two_mas.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;

				BubbleSort(m);
				Array.Reverse(m);
				Preobraz(m);
				data_three_mas.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
			}
		}
		static int[] BubbleSort(int[] mas)
		{
			int temp;
			for (int i = 0; i < mas.Length; i++)
			{
				for (int j = i + 1; j < mas.Length; j++)
				{
					if (mas[i] > mas[j])
					{
						temp = mas[i];
						mas[i] = mas[j];
						mas[j] = temp;
					}
				}
			}
			return mas;
		}
	}
}