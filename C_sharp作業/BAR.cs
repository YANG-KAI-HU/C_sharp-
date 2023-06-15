using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_sharp作業
{
    public partial class BAR : Form
    {
        public BAR()
        {
            InitializeComponent();
        }

 

        private void comboBox_gun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_gun.Text == "R-301-3000$")
            {
                pictureBox_gun.Image = Image.FromFile("R-301.jpg");
            }
            else if (comboBox_gun.Text == "R-99-2500$")
            {
               pictureBox_gun.Image = Image.FromFile("R-99.jpg");
            }
            else if (comboBox_gun.Text == "Nemesis-3400$")
            {
               pictureBox_gun.Image = Image.FromFile("Nemesis.jpg");
            }
            else if (comboBox_gun.Text == "Peacekeeper-2000$")
            {
               pictureBox_gun.Image = Image.FromFile("Peacekeeper.jpg");
            }
            else if (comboBox_gun.Text == "L-star-4000$")
            {
               pictureBox_gun.Image = Image.FromFile("L-star.jpg");
            }
            else if (comboBox_gun.Text == "Kraber-5000$")
            {
                pictureBox_gun.Image = Image.FromFile("Kraber.jpg");
            }
            textBox_gun.Focus();
        }
        private void textBox_gun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                checkoutbtn_Click(sender, e);
            }
        }
        private void textBox_gun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
       
        string Item_list="";
        int totleprice =0;

        public struct product
        {
            public string name;
            public int num;
        }

        bool check=true;
        List<product> pr = new List<product>();
        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            product pro;
            pro.name = comboBox_gun.Text;
            pro.num = int.Parse(textBox_gun.Text);
            
            if(check)
            {   
                pr.Add(pro);
                check = false;
            }
            else
            {
                bool exist=true;
                for (int i=0;i<pr.Count;i++)
                {
                    if (pro.name == pr[i].name)
                    {   
                        pro.num += pr[i].num;
                        pr.Remove(pr[i]);
                        pr.Add(pro);
                        exist = false;
                        break;
                    }
                }
                if(exist)
                    pr.Add(pro);
            }
            Item_list = "";
            totleprice = 0;
            for (int i=0;i<pr.Count;i++)
            {
                Item_list += pr[i].name + "*" + pr[i].num + "\r\n";
                string[] a = pr[i].name.Split('-');                  //將字串拆開
                string price = Regex.Replace((a[a.Length - 1]), "[^0-9]", "");//選取最後一個子串提取數字部分
                int singleprice = int.Parse(price);                         //轉型態
                totleprice += singleprice * pro.num;        //加入總價
                
            }
            moneycountlabel.Text = totleprice + "$";
            itemlist.Text = Item_list;
            //Item_list += comboBox_gun.Text+"*"+textBox_gun.Text+"\r\n";
            //string[] a = comboBox_gun.Text.Split('-');                  //將字串拆開
            //string price = Regex.Replace((a[a.Length-1]), "[^0-9]", "");//選取最後一個子串提取數字部分
            //int singleprice = int.Parse(price);                         //轉型態
            //totleprice+=singleprice*int.Parse(textBox_gun.Text);        //加入總價
            //moneycountlabel.Text = totleprice + "$"; 
            //itemlist.Text = Item_list;
        }

        private void cleanbtn_Click(object sender, EventArgs e)
        {
            totleprice = 0;
            Item_list = "";
            itemlist.Text = "";
            moneycountlabel.Text = "";
            bool check = true;
            pr.Clear();
        }

        private void CredBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "總金額為:" + totleprice*0.9+"$","結帳", MessageBoxButtons.OKCancel);
        }

        private void facepaybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額為:" + totleprice + "$", "結帳", MessageBoxButtons.OKCancel);
        }

       
    }
}
