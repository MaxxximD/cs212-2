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

namespace SYNC_WPF_
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public bool flag;
        public Window1()
        {
            InitializeComponent();
            flag = false;
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            if (!flag)
            {
                flag = true;
                button1.Content = "Возобновить синхронизацию";
            }
            else
            {
                flag = false;
                button1.Content = "Остановить синхронизацию";
                for (var i = 1; i <= 7; i++)
                    (FindName("textBox" + i) as TextBox).Text = (Owner.FindName("textBox" + i) as TextBox).Text;
            }
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

       
    }
}
