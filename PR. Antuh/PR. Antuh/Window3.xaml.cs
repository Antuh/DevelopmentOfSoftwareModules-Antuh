using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int q = 0, mq = 0;
            /*const int size = 10;
            const int min = -100, max = 100;
            int b = Convert.ToInt32(tb_zn.Text);

            int[] a = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++) a[i] = rnd.Next(min, max);*/

            int[] a = { 20, 3, 42, 3, 20, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                tb_mas.Text += a[i].ToString() + "\r\n";
            }
            foreach (int i in a)
            {
                foreach (int j in a)
                    if (i == j) q++;
                if (mq < q)
                    mq = q;
                q = 0;
            }
            lb_result.Content = ("Cамое большое кол-во одинаковых элементов : " + mq);
        }
    }
}
