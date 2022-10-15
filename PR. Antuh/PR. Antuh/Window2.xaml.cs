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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in tb_zn.Text.Split(' '))
            {
                if (item != "") list.Add(item.Trim());
            }

            list.Reverse();

            foreach (string str in list)
            {
                tb_result.Text = tb_result.Text + " " + str;
            }
        }
    }
}

