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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //panel_btn.Panel1.Controls.Add(button_Guess);
            //panel_btn.Panel1.Controls.Add(button_cal);
            //panel_btn.Panel1.Controls.Add(button_XO);
            //panel_btn.Panel1.Controls.Add(button_stu_gra);
            //panel_btn.Panel1.Controls.Add(button_stu);
            //panel_btn.Panel1.Controls.Add(button_Bar);
            //panel_btn.Panel1.Controls.Add(button_bank);
            //panel_btn.Panel1.Controls.Add(button_hello);

            
        }


        private void button_hello_Click(object sender, EventArgs e)
        {
            //this.splitContainer1.Panel1.;
            //sef sef = new sef();
            //sef.TopLevel = false;
            //sef.Parent = this.splitContainer1.Panel1;
            //sef.Show();
            OpenForm(new sef());
        }
        private Form currentForm;
        private void OpenForm(Form form)
        {
            // 檢查表單字典中是否已經存在該表單的參考
            //if (formDictionary.ContainsKey(formName))
            //{
            //    formDictionary[formName].Close();  // 如果已經存在，關閉該表單
            //    formDictionary.Remove(formName);   // 從字典中刪除該表單的參考
            //}
            if (currentForm != null)
            {
                currentForm.Close();  // 如果有已經打開的表單，關閉它
                currentForm.Dispose();  // 釋放該表單資源
            }

            currentForm = form;
            // 創建新的表單實例並添加到字典中
            //Form form = (Form)Activator.CreateInstance(formType);
            //form.FormClosed += (s, args) => formDictionary.Remove(formName);  // 表單關閉時從字典中刪除參考
            //formDictionary.Add(formName, form); 
            form.TopLevel = false;
            panel1.Controls.Add(form);
           
            //form.Parent = this.splitContainer1.Panel1;
            // 顯示表單
            form.Show();
        }

        private void button_bank_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //bank bank = new bank();
            //bank.TopLevel = false;
            //bank.Parent = this.splitContainer1.Panel1;
            //bank.Show();
            OpenForm(new bank());

        }

        private void button_Bar_Click(object sender, EventArgs e)
        {
            //BAR bar = new BAR();
            //bar.TopLevel = false;
            //bar.Parent = this.splitContainer1.Panel1;
            //bar.Show();
            OpenForm(new BAR());
        }

        private void button_stu_Click(object sender, EventArgs e)
        {
            //Stu_score stu = new Stu_score();
            //stu.TopLevel = false;
            //stu.Parent = this.splitContainer1.Panel1;
            //stu.Show();
            OpenForm(new Stu_score());
        }

        private void button_stu_gra_Click(object sender, EventArgs e)
        {
            //Student_grade stu = new Student_grade();
            //stu.TopLevel = false;
            //stu.Parent = this.splitContainer1.Panel1;
            //stu.Show();
            OpenForm(new Student_grade());
        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            //caculate cal = new caculate();
            //cal.TopLevel = false;
            //cal.Parent = this.splitContainer1.Panel1;
            //cal.Show();
            OpenForm(new caculate());
        }

        private void button_XO_Click(object sender, EventArgs e)
        {
            //XOgame xOgame = new XOgame();
            //xOgame.TopLevel = false;
            //xOgame.Parent = this.splitContainer1.Panel1;
            //xOgame.Show();
            OpenForm(new XOgame());
        }

        private void button_Guess_Click(object sender, EventArgs e)
        {
            //guess guess = new guess();
            //guess.TopLevel = false;
            //guess.Parent = this.splitContainer1.Panel1;
            //guess.Show();
            OpenForm(new guess());

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
