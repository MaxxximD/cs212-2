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
    public partial class Form2 : Form
    {

        public bool isClicked = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked)
                button1.Text = "Возобновить синхронизацию";
            else
            {
                button1.Text = "Остановить синхронизацию";
                for (var i = 1; i <= 7; i++)
                    (Controls["textBox" + i] as TextBox).Text = Owner.Controls["textBox" + i].Text;
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }


        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Button1_Click(sender, e);
                else if (e.KeyChar == (char)Keys.Escape)
                    Close();
                return;
            }
        }


    }
}
