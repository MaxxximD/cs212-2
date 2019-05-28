using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYNC_WF_
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(form2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!form2.isClicked)
                OwnedForms[0].Controls[(sender as TextBox).Name].Text = (sender as TextBox).Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Button1_Click(sender, e);
                return;
            }
        }


    }
}
