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
    public partial class sef : Form
    {
        public sef()
        {
            InitializeComponent();
        }

        string name(string C,string E,string S,string star)
        {
            return("我是" + C +
                ",\n英文名字是" + E +
                ",\n性別是" + S +
                ",\n星座是" + star+
                "\n很不高興認識你"
                );
        }
        
        private void helbtm_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello," + name(Cnmbox.Text, Enmbox.Text, sexbox.Text, starbox.Text));
        }

        private void hibtm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi," + name(Cnmbox.Text, Enmbox.Text, sexbox.Text, starbox.Text));
        }
    }
}
