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
    public partial class bank_report : Form
    {
        public bank_report()
        {
            InitializeComponent();
        }

        private void bank_report_Load(object sender, EventArgs e)
        {

            label_borrow.Text = classex.ttmoney.ToString();
            label_rate.Text = (classex.rate*1200).ToString();
            label_year.Text = classex.ptime.ToString();
            label_mp.Text= Math.Ceiling((classex.ttmoney - classex.fpay) * Math.Pow(1 + classex.rate, classex.ptime * 12) * classex.rate / (Math.Pow(1 + classex.rate, classex.ptime * 12) - 1)).ToString();
            label_ttm.Text = Math.Ceiling((classex.ttmoney - classex.fpay) * Math.Pow(1 + classex.rate, classex.ptime * 12) * classex.rate / (Math.Pow(1 + classex.rate, classex.ptime * 12) - 1)*12* classex.ptime).ToString();
        }

    }
}
