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
    public partial class XOgame : Form
    {
        public XOgame()
        {
            InitializeComponent();
        }

        static string  switch_XO = "X";
        static int count = 0;
        static int check = 0;
        string XO()
        {
            if (switch_XO == "X")
            {
                switch_XO = "O";
                label_turn.Text = "X的回合";
                return switch_XO;
            }
            else
            {
                switch_XO = "X";
                label_turn.Text = "O的回合";
                return switch_XO;
            }
        }
        void check_win()
        {
            check = 0;count++;
            if (button1.Text == switch_XO & button2.Text == switch_XO & button3.Text == switch_XO)
            {
                check = 1;
            }
            else if (button4.Text == switch_XO & button5.Text == switch_XO & button6.Text == switch_XO)
            {
                check = 1;
            }
            else if (button7.Text == switch_XO & button8.Text == switch_XO & button9.Text == switch_XO)
            {
                check = 1;
            }
            else if (button1.Text == switch_XO & button4.Text == switch_XO & button7.Text == switch_XO)
            {
                check = 1;
            }
            else if (button2.Text == switch_XO & button5.Text == switch_XO & button8.Text == switch_XO)
            {
                check = 1;
            }
            else if (button3.Text == switch_XO & button6.Text == switch_XO & button9.Text == switch_XO)
            {
                check = 1;
            }
            else if (button1.Text == switch_XO & button5.Text == switch_XO & button9.Text == switch_XO)
            {
                check = 1;
            }
            else if (button3.Text == switch_XO & button5.Text == switch_XO & button7.Text == switch_XO)
            {
                check = 1;
            }
            if (check == 1)
            {
                MessageBox.Show(switch_XO + " win");
                clear();
                
            }
            
            if (count == 9&check==0)
            {
                MessageBox.Show("平手");
                clear();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = XO();
            button1.Enabled= false;
            check_win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = XO();
            button2.Enabled = false;
            check_win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = XO();
            button3.Enabled = false;
            check_win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = XO();
            button4.Enabled = false;
            check_win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = XO();
            button5.Enabled = false;
            check_win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = XO();
            button6.Enabled = false;
            check_win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = XO();
            button7.Enabled = false;
            check_win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = XO();
            button8.Enabled = false;
            check_win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = XO();
            button9.Enabled = false;
            check_win();
        }

        private void button_re_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            foreach (Control item in Controls)
            {
                if (item.Text != "" & item.TabIndex < 9)
                    item.Text = "";
                    item.Enabled = true;
            }
            count = 0;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
