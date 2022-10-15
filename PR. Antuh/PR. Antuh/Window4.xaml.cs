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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const int size = 10;
            const int min = -100, max = 100;
            int b = Convert.ToInt32(tb_zn.Text);

            int[] a = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++) a[i] = rnd.Next(min, max);

            
            for (int i = 0; i < a.Length; i++)
            {
                tb_mas.Text += a[i].ToString() + "\r\n";
            };

            lb_b.Content = b;

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                tb_masa1.Text += a[i].ToString() + "\r\n";
            };
        }
    }
}
