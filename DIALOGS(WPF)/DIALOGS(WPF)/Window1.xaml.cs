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

namespace DIALOGS_WPF_
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1(string p)
        {
            InitializeComponent();
            passwordBox1.Password = p;
            passwordBox2.Password = p;
            passwordBox1.PasswordChar = '*';
            passwordBox2.PasswordChar = '*';


        }

        //Кнопка OK
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Owner as MainWindow;
            main.Password = passwordBox1.Password;
            DialogResult = true;
            MessageBox.Show("Пароль изменён!");
            
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }


        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Password == passwordBox2.Password && passwordBox1.Password != "")
                button1.IsEnabled = true;
            else
                button1.IsEnabled = false;
        }

        private void PasswordBox2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Password == passwordBox2.Password && passwordBox1.Password != "")
                button1.IsEnabled = true;
            else
                button1.IsEnabled = false;

        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        
    }
}
