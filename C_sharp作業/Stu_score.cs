using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C_sharp作業.classex;

namespace C_sharp作業
{
    public partial class Stu_score : Form
    {
        public Stu_score()
        {
            InitializeComponent();
        }

        private void textBox_ch_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoid(sender, e);
        }
        private void textBox_en_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoid(sender, e);
        }
        private void textBox_ma_KeyPress(object sender, KeyPressEventArgs e)
        {
            avoid(sender,e);
        }
        void avoid(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox_na_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        string tt_sc = "";
        private void sc_save_btn_Click(object sender, EventArgs e)
        {
            student_score ss = new student_score(textBox_name.Text, textBox_ch.Text, textBox_en.Text, textBox_ma.Text, textBox_na.Text);

            tt_sc = "";
            tt_sc += label_name.Text + ss.name + "\r\n";
            tt_sc += ch_sc.Text + ss.ch_sc + "\r\n";
            tt_sc += en_sc.Text + ss.en_sc + "\r\n";
            tt_sc += ma_sc.Text + ss.ma_sc + "\r\n";
            tt_sc += na_sc.Text + ss.na_sc + "\r\n";
        }

        private void show_sc_btn_Click(object sender, EventArgs e)
        {
            label_tt_sc.Text = tt_sc;
        }

        private void showhighlow_btn_Click(object sender, EventArgs e)
        {
            string[] clas= new string[4]{"國文","英文","數學","自然"};
            int[] arr = new int[4] { int.Parse(textBox_ch.Text) , int.Parse(textBox_en.Text), int.Parse(textBox_ma.Text), int.Parse(textBox_na.Text) }; 
            int h=0, l=0;
            //if (int.Parse(textBox_ch.Text) >h)
            //{
            //    h = int.Parse(textBox_ch.Text);        
            //}
            //else if (int.Parse(textBox_en.Text)>h) 
            //{
            //    h = int.Parse(textBox_ch.Text);
            //}
            //else if (int.Parse(textBox_na.Text) > h)
            //{
            //    h = int.Parse(textBox_na.Text);
            //}
            //else if (int.Parse(textBox_ma.Text) > h)
            //{
            //    h = int.Parse(textBox_ma.Text);
            //}
            h = arr.Max();
            int hg = Array.IndexOf(arr,h);
            l = arr.Min();
            int lg = Array.IndexOf(arr,l);
            label_highlow.Text = $"最高科目成績為:{clas[hg]}{h}分\n";
            label_highlow.Text += $"最低科目成績為:{clas[lg]}{l}分";
        }
    }
}
