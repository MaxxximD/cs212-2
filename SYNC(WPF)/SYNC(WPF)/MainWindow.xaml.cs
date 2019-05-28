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

namespace SYNC_WPF_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 win1 = new Window1();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            win1.Show();

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           if(!win1.flag)
                (OwnedWindows[0].FindName((sender as TextBox).Name) as TextBox).Text = (sender as TextBox).Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            win1.Owner = this;
        }
    }
}
