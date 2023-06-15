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
    public partial class caculate : Form
    {
        public caculate()
        {
            InitializeComponent();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBoxA.Text);
            decimal b = decimal.Parse(textBoxB.Text);
            textBox3.Text = (a + b).ToString();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBoxA.Text);
            decimal b = decimal.Parse(textBoxB.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void buttontimes_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBoxA.Text);
            decimal b = decimal.Parse(textBoxB.Text);
            textBox3.Text = (Math.Round(a * b, 2)).ToString();
        }

        private void buttondivided_Click(object sender, EventArgs e)
        {
            decimal a = decimal.Parse(textBoxA.Text);
            decimal b = decimal.Parse(textBoxB.Text);
            textBox3.Text = (Math.Round(a / b, 5)).ToString();
        }
    }
}
