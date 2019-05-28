using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DRAGDROP_WF_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.AllowDrop = true;
            richTextBox2.AllowDrop = true;
            richTextBox3.AllowDrop = true;

            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;

            richTextBox2.DragDrop += RichTextBox2_DragDrop;
            richTextBox2.DragEnter += RichTextBox2_DragEnter;

            richTextBox3.DragDrop += RichTextBox3_DragDrop;
            richTextBox3.DragEnter += RichTextBox3_DragEnter;
        }

        //Возникает, когда пользователь затаскивает что-нибудь в richTextBox1
        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data.GetDataPresent(typeof(RichTextBox)))
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (rb.Text != "")
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Возникает, когда пользователь отпускает кнопку мыши
        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".txt")
                    {
                        if (richTextBox1.Text == "")
                            richTextBox1.Lines = File.ReadAllLines(file, Encoding.Default);
                        else
                            foreach (var f in File.ReadAllLines(file, Encoding.Default))
                                richTextBox1.AppendText(f);
                    }
                    else
                        MessageBox.Show("Только файлы с расширением txt");
                }
            }
            else
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (richTextBox1.Text == "")
                    richTextBox1.Text = rb.Text;
                else
                    richTextBox1.AppendText(rb.Text);

            }
            richTextBox1.Focus();

        }

        private void RichTextBox2_DragEnter(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data.GetDataPresent(typeof(RichTextBox)))
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (rb.Text != "")
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void RichTextBox2_DragDrop(object sender, DragEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".txt")
                    {
                        if (richTextBox2.Text == "")
                            richTextBox2.Lines = File.ReadAllLines(file, Encoding.Default);
                        else
                            foreach (var f in File.ReadAllLines(file, Encoding.Default))
                                richTextBox2.AppendText(f);
                    }
                    else
                        MessageBox.Show("Только файлы с расширением txt");

                }
            }
            else
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (richTextBox2.Text == "")
                    richTextBox2.Text = rb.Text;
                else
                    richTextBox2.AppendText(rb.Text);
            }
            richTextBox2.Focus();
        }



        private void RichTextBox3_DragEnter(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data.GetDataPresent(typeof(RichTextBox)))
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (rb.Text != "")
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void RichTextBox3_DragDrop(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".txt")
                    {
                        if (richTextBox3.Text == "")
                            richTextBox3.Lines = File.ReadAllLines(file, Encoding.Default);
                        else
                            foreach (var f in File.ReadAllLines(file, Encoding.Default))
                                richTextBox3.AppendText(f);
                    }
                    else
                        MessageBox.Show("Только файлы с расширением txt");
                }
            }
            else
            {
                RichTextBox rb = (RichTextBox)e.Data.GetData(typeof(RichTextBox));
                if (richTextBox3.Text == "")
                    richTextBox3.Text = rb.Text;
                else
                    richTextBox3.AppendText(rb.Text);
            }
            richTextBox3.Focus();

        }

        //Clear
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Focused)
                richTextBox1.Clear();
            if (richTextBox2.Focused)
                richTextBox2.Clear();
            if (richTextBox3.Focused)
                richTextBox3.Clear();
        }
        
        //Exit
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Проверяют, зажата ли клавиша Ctrl
        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.ControlKey)
                DoDragDrop(sender as RichTextBox, DragDropEffects.Copy);
        }

        private void RichTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.ControlKey)
                DoDragDrop(sender as RichTextBox, DragDropEffects.Copy);
        }

        private void RichTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.ControlKey)
                DoDragDrop(sender as RichTextBox, DragDropEffects.Copy);
        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
