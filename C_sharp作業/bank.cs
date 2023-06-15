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
    public partial class bank : Form
    {
        public bank()
        {
            InitializeComponent();
        }

        double pay;

        public void paym_Click(object sender, EventArgs e)
        {
            monpay();
            MessageBox.Show("月繳:" + Math.Floor(pay));


        }

        public void stackmoney_Click(object sender, EventArgs e)
        {
            monpay();
            MessageBox.Show("總金額:" + Math.Floor(pay)*12*double.Parse(textBox_time.Text));
        }
        
        private void paylist_Click(object sender, EventArgs e)
        {
            classex.ttmoney = double.Parse(textBox_tt.Text);;
            classex.rate=double.Parse(textBox_rate.Text) * 1 / 1200;
            classex.ptime = double.Parse(textBox_time.Text);
            classex.fpay = double.Parse(textBox_FM.Text);

            bank_report bp = new bank_report();
            bp.Show();
            
        }

        void monpay()
        {   
            double ttmoney = double.Parse(textBox_tt.Text);
            double rate = double.Parse(textBox_rate.Text) * 1 / 1200;
            double ptime = double.Parse(textBox_time.Text);
            double fpay = double.Parse(textBox_FM.Text);
            if (rate!= 0)
            {
            pay = (ttmoney - fpay) * Math.Pow(1 + rate, ptime * 12) * rate / (Math.Pow(1 + rate, ptime * 12) - 1);
            }
            else
            {
                pay = ttmoney / (ptime * 12);
            }
        } 
        void ypay()
        {
            double ttmoney = double.Parse(textBox_tt.Text);
            double rate = double.Parse(textBox_rate.Text) * 1 / 1200;
            double ptime = double.Parse(textBox_time.Text);
            double fpay = double.Parse(textBox_FM.Text);
            pay = (ttmoney - fpay) * Math.Pow(1 + rate, ptime * 12) * rate / (Math.Pow(1 + rate, ptime * 12) - 1);
        }
    }
}
