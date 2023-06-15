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
    public partial class Student_grade : Form
    {
        public Student_grade()
        {
            InitializeComponent();
        }
        List<student_data> sd =new List<student_data>();
        private void button_add_Click(object sender, EventArgs e)
        {
            student_data std;
            std.name = textBox_n.Text;
            std.ch=textBox_ch.Text;
            std.en=textBox_en.Text;
            std.ma=textBox_ma.Text;
            sd.Add(std);
            textchange();
            button_result.Enabled = true;
        }

        void textchange()
        {   
            string result = "";
            string[] clas = new string[3] { "國文", "英文", "數學" };
            
            for (int i=0;i < sd.Count;i++)
            {
                int ch = int.Parse(sd[i].ch);
                int en = int.Parse(sd[i].en);
                int ma = int.Parse(sd[i].ma);

                int[] arr = new int[3] { ch, en, ma };
                int h = 0, l = 0;
                h = arr.Max();
                int hg = Array.IndexOf(arr, h);
                l = arr.Min();
                int lg = Array.IndexOf(arr, l);
                decimal t = ch+en+ma;
                decimal t_a=Math.Round(t/3,2);
                result += $"{sd[i].name,-8}{ch,+8}{en,12}{ma,12}{t,12}{t_a,12}{clas[hg]+h,12}{clas[lg]+l,12}\n";

            }
            richTextBox1.Text=result;
        }

        private void button_addr_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            student_data std = new student_data();
            std.name = sd.Count+1+"";
            std.ch = random.Next(60, 101) + "";//隨機給值(60,100)
            std.en = random.Next(60, 101) + "";
            std.ma = random.Next(60, 101) + "";
            sd.Add(std);
            textchange();
            button_result.Enabled = true;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            string result = "";
            int ch = 0,c_h=0,c_l=0;
            int en = 0,e_h=0,e_l=0;
            int ma = 0,m_h=0,m_l=0;
         
            for (int i = 0;i<sd.Count;i++)
            {
                ch += int.Parse(sd[i].ch);//各科加總
                en += int.Parse(sd[i].en);
                ma += int.Parse(sd[i].ma);

                if(c_h< int.Parse(sd[i].ch) |i == 0)//各科的最大最小值
                {
                    c_h = int.Parse(sd[i].ch);
                }
                if(c_l> int.Parse(sd[i].ch) | i == 0)
                {
                    c_l= int.Parse(sd[i].ch);
                }
                if (e_h < int.Parse(sd[i].en) | i == 0)
                {
                    e_h = int.Parse(sd[i].en);
                }
                if (e_l > int.Parse(sd[i].en) | i == 0)
                {
                    e_l = int.Parse(sd[i].en);
                }
                if (m_h < int.Parse(sd[i].ma) | i == 0)
                {
                    m_h = int.Parse(sd[i].ma);
                }
                if (m_l > int.Parse(sd[i].ma) | i == 0)
                {
                    m_l = int.Parse(sd[i].ma);
                }
            }
            decimal cd = Math.Round(((decimal)ch / sd.Count),2);//轉換成十進制算小數點
            decimal ed = Math.Round(((decimal)en / sd.Count), 2);
            decimal md = Math.Round(((decimal)ma / sd.Count), 2);
            result += $"總分{ch,20}{en,12}{ma,12}\n";
            result += $"平均{cd,20}{ed,12}{md,12}\n";
            result += $"最高分{c_h,20}{e_h,12}{m_h,12}\n";
            result += $"最低分{c_l,20}{e_l,12}{m_l,12}\n";
            label_tts.Text = result ;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            sd.Clear();
            button_result.Enabled = false;
            richTextBox1.Text = "";
            label_tts.Text = "";

        }

        private void button_ran20_Click(object sender, EventArgs e)
        { 
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                student_data std = new student_data();
                std.name = sd.Count + 1 + "";
                std.ch = random.Next(60, 101) + "";//隨機給值(60,100)
                std.en = random.Next(60, 101) + "";
                std.ma = random.Next(60, 101) + "";
                sd.Add(std);
            }
            textchange();
            button_result.Enabled = true;
        }
    }
}
