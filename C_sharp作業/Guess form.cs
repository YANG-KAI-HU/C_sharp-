using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_sharp作業
{
    public partial class Guess_form : Form
    {
        public Guess_form()
        {
            InitializeComponent();
        }

        private void button_guess_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBox_num.Text,out num))
            {
                if (num > classex.guess_n)
                    label_title.Text = "太大了,小一點!";
                else if (num < classex.guess_n)
                    label_title.Text = "太小了,大一點!";
                else
                {
                    label_title.Text = "Bingo!!!";
                }
            }
            
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_num_Enter(object sender, EventArgs e)
        {
            button_guess_Click(sender, e);
        }

        private void textBox_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                button_guess_Click(sender, e);
            }
        }
    }
}
