namespace C_sharp作業
{
    partial class Menu
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
            this.button_hello = new System.Windows.Forms.Button();
            this.button_bank = new System.Windows.Forms.Button();
            this.button_Bar = new System.Windows.Forms.Button();
            this.button_stu = new System.Windows.Forms.Button();
            this.button_stu_gra = new System.Windows.Forms.Button();
            this.button_cal = new System.Windows.Forms.Button();
            this.button_XO = new System.Windows.Forms.Button();
            this.button_Guess = new System.Windows.Forms.Button();
            this.panel_btn = new System.Windows.Forms.SplitContainer();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).BeginInit();
            this.panel_btn.Panel1.SuspendLayout();
            this.panel_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.Location = new System.Drawing.Point(7, 12);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(135, 30);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "Hello";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // button_bank
            // 
            this.button_bank.Location = new System.Drawing.Point(7, 48);
            this.button_bank.Name = "button_bank";
            this.button_bank.Size = new System.Drawing.Size(135, 30);
            this.button_bank.TabIndex = 1;
            this.button_bank.Text = "貸款";
            this.button_bank.UseVisualStyleBackColor = true;
            this.button_bank.Click += new System.EventHandler(this.button_bank_Click);
            // 
            // button_Bar
            // 
            this.button_Bar.Location = new System.Drawing.Point(7, 84);
            this.button_Bar.Name = "button_Bar";
            this.button_Bar.Size = new System.Drawing.Size(135, 30);
            this.button_Bar.TabIndex = 2;
            this.button_Bar.Text = "APEX_shopping";
            this.button_Bar.UseVisualStyleBackColor = true;
            this.button_Bar.Click += new System.EventHandler(this.button_Bar_Click);
            // 
            // button_stu
            // 
            this.button_stu.Location = new System.Drawing.Point(7, 120);
            this.button_stu.Name = "button_stu";
            this.button_stu.Size = new System.Drawing.Size(135, 30);
            this.button_stu.TabIndex = 3;
            this.button_stu.Text = "學生成績";
            this.button_stu.UseVisualStyleBackColor = true;
            this.button_stu.Click += new System.EventHandler(this.button_stu_Click);
            // 
            // button_stu_gra
            // 
            this.button_stu_gra.Location = new System.Drawing.Point(7, 156);
            this.button_stu_gra.Name = "button_stu_gra";
            this.button_stu_gra.Size = new System.Drawing.Size(135, 30);
            this.button_stu_gra.TabIndex = 4;
            this.button_stu_gra.Text = "學生成績總表";
            this.button_stu_gra.UseVisualStyleBackColor = true;
            this.button_stu_gra.Click += new System.EventHandler(this.button_stu_gra_Click);
            // 
            // button_cal
            // 
            this.button_cal.Location = new System.Drawing.Point(7, 192);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(135, 30);
            this.button_cal.TabIndex = 5;
            this.button_cal.Text = "簡易計算機";
            this.button_cal.UseVisualStyleBackColor = true;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // button_XO
            // 
            this.button_XO.Location = new System.Drawing.Point(7, 228);
            this.button_XO.Name = "button_XO";
            this.button_XO.Size = new System.Drawing.Size(135, 30);
            this.button_XO.TabIndex = 6;
            this.button_XO.Text = "井字遊戲";
            this.button_XO.UseVisualStyleBackColor = true;
            this.button_XO.Click += new System.EventHandler(this.button_XO_Click);
            // 
            // button_Guess
            // 
            this.button_Guess.Location = new System.Drawing.Point(7, 264);
            this.button_Guess.Name = "button_Guess";
            this.button_Guess.Padding = new System.Windows.Forms.Padding(1);
            this.button_Guess.Size = new System.Drawing.Size(135, 30);
            this.button_Guess.TabIndex = 7;
            this.button_Guess.Text = "終極密碼";
            this.button_Guess.UseVisualStyleBackColor = true;
            this.button_Guess.Click += new System.EventHandler(this.button_Guess_Click);
            // 
            // panel_btn
            // 
            this.panel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_btn.Location = new System.Drawing.Point(4, 146);
            this.panel_btn.Name = "panel_btn";
            // 
            // panel_btn.Panel1
            // 
            this.panel_btn.Panel1.AutoScroll = true;
            this.panel_btn.Panel1.BackgroundImage = global::C_sharp作業.Properties.Resources.wallpaperflare_com_wallpaper__2_;
            this.panel_btn.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_btn.Panel1.Controls.Add(this.button_Guess);
            this.panel_btn.Panel1.Controls.Add(this.button_XO);
            this.panel_btn.Panel1.Controls.Add(this.button_cal);
            this.panel_btn.Panel1.Controls.Add(this.button_stu_gra);
            this.panel_btn.Panel1.Controls.Add(this.button_stu);
            this.panel_btn.Panel1.Controls.Add(this.button_Bar);
            this.panel_btn.Panel1.Controls.Add(this.button_hello);
            this.panel_btn.Panel1.Controls.Add(this.button_bank);
            this.panel_btn.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.panel_btn.Panel2Collapsed = true;
            this.panel_btn.Size = new System.Drawing.Size(150, 506);
            this.panel_btn.TabIndex = 11;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_title.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Image = global::C_sharp作業.Properties.Resources.wallpaperflare_com_wallpaper__4_;
            this.label_title.Location = new System.Drawing.Point(4, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(964, 139);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "C#作業";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::C_sharp作業.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(156, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 506);
            this.panel1.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 657);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_btn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel_btn.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_btn)).EndInit();
            this.panel_btn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.Button button_bank;
        private System.Windows.Forms.Button button_Bar;
        private System.Windows.Forms.Button button_stu;
        private System.Windows.Forms.Button button_stu_gra;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.Button button_XO;
        private System.Windows.Forms.Button button_Guess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.SplitContainer panel_btn;
    }
}