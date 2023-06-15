namespace C_sharp作業
{
    partial class Stu_score
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
            this.ch_sc = new System.Windows.Forms.Label();
            this.en_sc = new System.Windows.Forms.Label();
            this.ma_sc = new System.Windows.Forms.Label();
            this.na_sc = new System.Windows.Forms.Label();
            this.textBox_ch = new System.Windows.Forms.TextBox();
            this.textBox_en = new System.Windows.Forms.TextBox();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.textBox_na = new System.Windows.Forms.TextBox();
            this.label_sc = new System.Windows.Forms.Label();
            this.label_tt_sc = new System.Windows.Forms.Label();
            this.label_highlow = new System.Windows.Forms.Label();
            this.sc_save_btn = new System.Windows.Forms.Button();
            this.show_sc_btn = new System.Windows.Forms.Button();
            this.showhighlow_btn = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ch_sc
            // 
            this.ch_sc.AutoSize = true;
            this.ch_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ch_sc.Location = new System.Drawing.Point(56, 62);
            this.ch_sc.Name = "ch_sc";
            this.ch_sc.Size = new System.Drawing.Size(104, 21);
            this.ch_sc.TabIndex = 0;
            this.ch_sc.Text = "國文成績:";
            // 
            // en_sc
            // 
            this.en_sc.AutoSize = true;
            this.en_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.en_sc.Location = new System.Drawing.Point(56, 108);
            this.en_sc.Name = "en_sc";
            this.en_sc.Size = new System.Drawing.Size(104, 21);
            this.en_sc.TabIndex = 1;
            this.en_sc.Text = "英文成績:";
            // 
            // ma_sc
            // 
            this.ma_sc.AutoSize = true;
            this.ma_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ma_sc.Location = new System.Drawing.Point(56, 157);
            this.ma_sc.Name = "ma_sc";
            this.ma_sc.Size = new System.Drawing.Size(104, 21);
            this.ma_sc.TabIndex = 2;
            this.ma_sc.Text = "數學成績:";
            // 
            // na_sc
            // 
            this.na_sc.AutoSize = true;
            this.na_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.na_sc.Location = new System.Drawing.Point(56, 202);
            this.na_sc.Name = "na_sc";
            this.na_sc.Size = new System.Drawing.Size(104, 21);
            this.na_sc.TabIndex = 3;
            this.na_sc.Text = "自然成績:";
            // 
            // textBox_ch
            // 
            this.textBox_ch.Location = new System.Drawing.Point(183, 61);
            this.textBox_ch.Name = "textBox_ch";
            this.textBox_ch.Size = new System.Drawing.Size(100, 22);
            this.textBox_ch.TabIndex = 4;
            this.textBox_ch.Text = "10";
            this.textBox_ch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ch_KeyPress);
            // 
            // textBox_en
            // 
            this.textBox_en.Location = new System.Drawing.Point(183, 112);
            this.textBox_en.Name = "textBox_en";
            this.textBox_en.Size = new System.Drawing.Size(100, 22);
            this.textBox_en.TabIndex = 5;
            this.textBox_en.Text = "20";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(183, 161);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(100, 22);
            this.textBox_ma.TabIndex = 6;
            this.textBox_ma.Text = "30";
            // 
            // textBox_na
            // 
            this.textBox_na.Location = new System.Drawing.Point(183, 206);
            this.textBox_na.Name = "textBox_na";
            this.textBox_na.Size = new System.Drawing.Size(100, 22);
            this.textBox_na.TabIndex = 7;
            this.textBox_na.Text = "40";
            // 
            // label_sc
            // 
            this.label_sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_sc.Location = new System.Drawing.Point(326, 34);
            this.label_sc.Name = "label_sc";
            this.label_sc.Size = new System.Drawing.Size(246, 262);
            this.label_sc.TabIndex = 8;
            this.label_sc.Text = "總成績";
            // 
            // label_tt_sc
            // 
            this.label_tt_sc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_tt_sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_tt_sc.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_tt_sc.Location = new System.Drawing.Point(335, 56);
            this.label_tt_sc.Margin = new System.Windows.Forms.Padding(0);
            this.label_tt_sc.Name = "label_tt_sc";
            this.label_tt_sc.Size = new System.Drawing.Size(227, 122);
            this.label_tt_sc.TabIndex = 9;
            // 
            // label_highlow
            // 
            this.label_highlow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_highlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_highlow.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_highlow.Location = new System.Drawing.Point(335, 192);
            this.label_highlow.Margin = new System.Windows.Forms.Padding(0);
            this.label_highlow.Name = "label_highlow";
            this.label_highlow.Size = new System.Drawing.Size(227, 94);
            this.label_highlow.TabIndex = 10;
            // 
            // sc_save_btn
            // 
            this.sc_save_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.sc_save_btn.Location = new System.Drawing.Point(60, 276);
            this.sc_save_btn.Name = "sc_save_btn";
            this.sc_save_btn.Size = new System.Drawing.Size(94, 38);
            this.sc_save_btn.TabIndex = 11;
            this.sc_save_btn.Text = "存入成績";
            this.sc_save_btn.UseVisualStyleBackColor = true;
            this.sc_save_btn.Click += new System.EventHandler(this.sc_save_btn_Click);
            // 
            // show_sc_btn
            // 
            this.show_sc_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.show_sc_btn.Location = new System.Drawing.Point(183, 276);
            this.show_sc_btn.Name = "show_sc_btn";
            this.show_sc_btn.Size = new System.Drawing.Size(94, 38);
            this.show_sc_btn.TabIndex = 12;
            this.show_sc_btn.Text = "顯示成績";
            this.show_sc_btn.UseVisualStyleBackColor = true;
            this.show_sc_btn.Click += new System.EventHandler(this.show_sc_btn_Click);
            // 
            // showhighlow_btn
            // 
            this.showhighlow_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.showhighlow_btn.Location = new System.Drawing.Point(443, 310);
            this.showhighlow_btn.Name = "showhighlow_btn";
            this.showhighlow_btn.Size = new System.Drawing.Size(119, 53);
            this.showhighlow_btn.TabIndex = 13;
            this.showhighlow_btn.Text = "顯示最高/低成績";
            this.showhighlow_btn.UseVisualStyleBackColor = true;
            this.showhighlow_btn.Click += new System.EventHandler(this.showhighlow_btn_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(56, 23);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 21);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "姓名:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(183, 22);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 15;
            this.textBox_name.Text = "AA";
            // 
            // Stu_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.showhighlow_btn);
            this.Controls.Add(this.show_sc_btn);
            this.Controls.Add(this.sc_save_btn);
            this.Controls.Add(this.label_highlow);
            this.Controls.Add(this.label_tt_sc);
            this.Controls.Add(this.label_sc);
            this.Controls.Add(this.textBox_na);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.textBox_en);
            this.Controls.Add(this.textBox_ch);
            this.Controls.Add(this.na_sc);
            this.Controls.Add(this.ma_sc);
            this.Controls.Add(this.en_sc);
            this.Controls.Add(this.ch_sc);
            this.Name = "Stu_score";
            this.Text = "Stu_score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ch_sc;
        private System.Windows.Forms.Label en_sc;
        private System.Windows.Forms.Label ma_sc;
        private System.Windows.Forms.Label na_sc;
        private System.Windows.Forms.TextBox textBox_ch;
        private System.Windows.Forms.TextBox textBox_en;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.TextBox textBox_na;
        private System.Windows.Forms.Label label_sc;
        private System.Windows.Forms.Label label_tt_sc;
        private System.Windows.Forms.Label label_highlow;
        private System.Windows.Forms.Button sc_save_btn;
        private System.Windows.Forms.Button show_sc_btn;
        private System.Windows.Forms.Button showhighlow_btn;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
    }
}