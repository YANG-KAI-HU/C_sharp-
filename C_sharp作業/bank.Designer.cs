namespace C_sharp作業
{
    partial class bank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_tt = new System.Windows.Forms.TextBox();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_FM = new System.Windows.Forms.TextBox();
            this.totmoney = new System.Windows.Forms.Label();
            this.paytime = new System.Windows.Forms.Label();
            this.persent = new System.Windows.Forms.Label();
            this.firstmoney = new System.Windows.Forms.Label();
            this.paym = new System.Windows.Forms.Button();
            this.stackmoney = new System.Windows.Forms.Button();
            this.paylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_tt
            // 
            this.textBox_tt.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_tt.Location = new System.Drawing.Point(356, 76);
            this.textBox_tt.Name = "textBox_tt";
            this.textBox_tt.Size = new System.Drawing.Size(100, 30);
            this.textBox_tt.TabIndex = 0;
            this.textBox_tt.Text = "100000";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_rate.Location = new System.Drawing.Point(356, 177);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(100, 30);
            this.textBox_rate.TabIndex = 1;
            this.textBox_rate.Text = "10";
            // 
            // textBox_time
            // 
            this.textBox_time.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_time.Location = new System.Drawing.Point(356, 124);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(100, 30);
            this.textBox_time.TabIndex = 1;
            this.textBox_time.Text = "2";
            // 
            // textBox_FM
            // 
            this.textBox_FM.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_FM.Location = new System.Drawing.Point(356, 225);
            this.textBox_FM.Name = "textBox_FM";
            this.textBox_FM.Size = new System.Drawing.Size(100, 30);
            this.textBox_FM.TabIndex = 2;
            this.textBox_FM.Text = "0";
            // 
            // totmoney
            // 
            this.totmoney.AutoSize = true;
            this.totmoney.Font = new System.Drawing.Font("新細明體", 14F);
            this.totmoney.Location = new System.Drawing.Point(258, 79);
            this.totmoney.Name = "totmoney";
            this.totmoney.Size = new System.Drawing.Size(85, 19);
            this.totmoney.TabIndex = 3;
            this.totmoney.Text = "貸款金額";
            // 
            // paytime
            // 
            this.paytime.AutoSize = true;
            this.paytime.Font = new System.Drawing.Font("新細明體", 14F);
            this.paytime.Location = new System.Drawing.Point(258, 127);
            this.paytime.Name = "paytime";
            this.paytime.Size = new System.Drawing.Size(78, 19);
            this.paytime.TabIndex = 4;
            this.paytime.Text = "期限(年)";
            // 
            // persent
            // 
            this.persent.AutoSize = true;
            this.persent.Font = new System.Drawing.Font("新細明體", 14F);
            this.persent.Location = new System.Drawing.Point(258, 180);
            this.persent.Name = "persent";
            this.persent.Size = new System.Drawing.Size(74, 19);
            this.persent.TabIndex = 5;
            this.persent.Text = "利率(%)";
            // 
            // firstmoney
            // 
            this.firstmoney.AutoSize = true;
            this.firstmoney.Font = new System.Drawing.Font("新細明體", 14F);
            this.firstmoney.Location = new System.Drawing.Point(258, 228);
            this.firstmoney.Name = "firstmoney";
            this.firstmoney.Size = new System.Drawing.Size(66, 19);
            this.firstmoney.TabIndex = 6;
            this.firstmoney.Text = "頭期款";
            // 
            // paym
            // 
            this.paym.Location = new System.Drawing.Point(239, 312);
            this.paym.Name = "paym";
            this.paym.Size = new System.Drawing.Size(75, 43);
            this.paym.TabIndex = 7;
            this.paym.Text = "月付";
            this.paym.UseVisualStyleBackColor = true;
            this.paym.Click += new System.EventHandler(this.paym_Click);
            // 
            // stackmoney
            // 
            this.stackmoney.Location = new System.Drawing.Point(356, 312);
            this.stackmoney.Name = "stackmoney";
            this.stackmoney.Size = new System.Drawing.Size(75, 43);
            this.stackmoney.TabIndex = 8;
            this.stackmoney.Text = "總金額";
            this.stackmoney.UseVisualStyleBackColor = true;
            this.stackmoney.Click += new System.EventHandler(this.stackmoney_Click);
            // 
            // paylist
            // 
            this.paylist.Location = new System.Drawing.Point(480, 312);
            this.paylist.Name = "paylist";
            this.paylist.Size = new System.Drawing.Size(75, 43);
            this.paylist.TabIndex = 9;
            this.paylist.Text = "表單";
            this.paylist.UseVisualStyleBackColor = true;
            this.paylist.Click += new System.EventHandler(this.paylist_Click);
            // 
            // bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paylist);
            this.Controls.Add(this.stackmoney);
            this.Controls.Add(this.paym);
            this.Controls.Add(this.firstmoney);
            this.Controls.Add(this.persent);
            this.Controls.Add(this.paytime);
            this.Controls.Add(this.totmoney);
            this.Controls.Add(this.textBox_FM);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.textBox_tt);
            this.Name = "bank";
            this.Text = "bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tt;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_FM;
        private System.Windows.Forms.Label totmoney;
        private System.Windows.Forms.Label paytime;
        private System.Windows.Forms.Label persent;
        private System.Windows.Forms.Label firstmoney;
        private System.Windows.Forms.Button paym;
        private System.Windows.Forms.Button stackmoney;
        private System.Windows.Forms.Button paylist;
    }
}