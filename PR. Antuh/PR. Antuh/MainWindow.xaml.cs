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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR.Antuh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 f = new Window1();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 f = new Window2();
            f.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 f = new Window3();
            f.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 f = new Window4();
            f.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 f = new Window5();
            f.Show();
        }
    }
}
