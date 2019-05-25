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

namespace DIALOGS_WPF_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Password { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            Password = "qwerty";
            passwordBox1.PasswordChar = '*';
           

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            if (passwordBox1.Password == Password)
            {
                Window1 win1 = new Window1(Password);
                win1.Owner = this;
                win1.ShowDialog();
               
            }
            else
                MessageBox.Show("Неверный пароль!");
             
        }

       

        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            

        }

    }
}
