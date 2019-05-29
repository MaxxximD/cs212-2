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
using System.IO;

namespace DRAGDROP_WPF_
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

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(typeof(TextBox)))
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;
        }

        private void RichTextBox1_Drop(object sender, DragEventArgs e)
        {
             

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (System.IO.Path.GetExtension(file) == ".txt")
                        richTextBox1.AppendText(File.ReadAllText(file, Encoding.Default));
                    else
                        MessageBox.Show("Только файлы с расширением txt!");
                }
                richTextBox1.Focus();
            }
            
            if(e.Data.GetDataPresent(typeof(TextBox)))
            {
                TextBox tb = (TextBox)e.Data.GetData(typeof(TextBox));

                if (tb.Text != "")
                {
                    richTextBox1.AppendText(tb.Text);
                    richTextBox1.Focus();
                }
                else
                    MessageBox.Show("Поле ввода не должно быть пустым!");
            }

            
        }

        private void RichTextBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(typeof(TextBox)))
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;
        }

        private void RichTextBox2_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (System.IO.Path.GetExtension(file) == ".txt")
                        richTextBox2.AppendText(File.ReadAllText(file, Encoding.Default));
                    else
                        MessageBox.Show("Только файлы с расширением txt!");
                }
                richTextBox2.Focus();
            }

            if (e.Data.GetDataPresent(typeof(TextBox)))
            {
                TextBox tb = (TextBox)e.Data.GetData(typeof(TextBox));

                if (tb.Text != "")
                {
                    richTextBox2.AppendText(tb.Text);
                    richTextBox2.Focus();
                }
                else
                    MessageBox.Show("Поле ввода не должно быть пустым!");
            }

        }

        private void RichTextBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(typeof(TextBox)))
                e.Effects = DragDropEffects.Copy;
            else
                e.Effects = DragDropEffects.None;
        }

        private void RichTextBox3_Drop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (System.IO.Path.GetExtension(file) == ".txt")
                        richTextBox3.AppendText(File.ReadAllText(file, Encoding.Default));
                    else
                        MessageBox.Show("Только файлы с расширением txt!");
                }
                richTextBox3.Focus();
            }

            if (e.Data.GetDataPresent(typeof(TextBox)))
            {
                TextBox tb = (TextBox)e.Data.GetData(typeof(TextBox));

                if (tb.Text != "")
                {
                    richTextBox3.AppendText(tb.Text);
                    richTextBox3.Focus();
                }
                else
                    MessageBox.Show("Поле ввода не должно быть пустым!");
            }
        }




        private void Exit0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox1.IsFocused)
                richTextBox1.Clear();
            else if(richTextBox2.IsFocused)
                richTextBox2.Clear();
            else
                richTextBox3.Clear();
        }

        private void RichTextBox1_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void RichTextBox2_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void RichTextBox3_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

       

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.LeftCtrl)
                DragDrop.DoDragDrop(sender as TextBox, sender, DragDropEffects.Copy);
        }
    }
}
