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
    public partial class guess : Form
    {
        public guess()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            classex.guess_num();
            Guess_form gf = new Guess_form();
            gf.ShowDialog();
        }

        private void buttonans_Click(object sender, EventArgs e)
        {
            MessageBox.Show(classex.guess_n+"","答案就是");
        }
    }
}
