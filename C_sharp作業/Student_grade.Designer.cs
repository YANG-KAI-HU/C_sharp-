namespace C_sharp作業
{
    partial class Student_grade
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
            this.button_add = new System.Windows.Forms.Button();
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_ch = new System.Windows.Forms.TextBox();
            this.textBox_en = new System.Windows.Forms.TextBox();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.lable_ch = new System.Windows.Forms.Label();
            this.label_en = new System.Windows.Forms.Label();
            this.label_ma = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_tts = new System.Windows.Forms.Label();
            this.button_addr = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_ran20 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_scroe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(24, 175);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 40);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "加入資料";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_n.Location = new System.Drawing.Point(11, 13);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(60, 21);
            this.label_n.TabIndex = 1;
            this.label_n.Text = "姓名:";
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_n.Location = new System.Drawing.Point(72, 10);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(73, 33);
            this.textBox_n.TabIndex = 2;
            this.textBox_n.Text = "AAA";
            // 
            // textBox_ch
            // 
            this.textBox_ch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ch.Location = new System.Drawing.Point(72, 53);
            this.textBox_ch.Name = "textBox_ch";
            this.textBox_ch.Size = new System.Drawing.Size(73, 33);
            this.textBox_ch.TabIndex = 3;
            this.textBox_ch.Text = "20";
            // 
            // textBox_en
            // 
            this.textBox_en.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_en.Location = new System.Drawing.Point(72, 92);
            this.textBox_en.Name = "textBox_en";
            this.textBox_en.Size = new System.Drawing.Size(73, 33);
            this.textBox_en.TabIndex = 4;
            this.textBox_en.Text = "40";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.textBox_ma.Location = new System.Drawing.Point(72, 131);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(73, 33);
            this.textBox_ma.TabIndex = 5;
            this.textBox_ma.Text = "50";
            // 
            // lable_ch
            // 
            this.lable_ch.AutoSize = true;
            this.lable_ch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable_ch.Location = new System.Drawing.Point(11, 56);
            this.lable_ch.Name = "lable_ch";
            this.lable_ch.Size = new System.Drawing.Size(60, 21);
            this.lable_ch.TabIndex = 6;
            this.lable_ch.Text = "國文:";
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_en.Location = new System.Drawing.Point(11, 95);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(60, 21);
            this.label_en.TabIndex = 7;
            this.label_en.Text = "英文:";
            // 
            // label_ma
            // 
            this.label_ma.AutoSize = true;
            this.label_ma.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ma.Location = new System.Drawing.Point(12, 134);
            this.label_ma.Name = "label_ma";
            this.label_ma.Size = new System.Drawing.Size(60, 21);
            this.label_ma.TabIndex = 8;
            this.label_ma.Text = "數學:";
            // 
            // label_title
            // 
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_title.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.Location = new System.Drawing.Point(151, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(418, 279);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "姓名           國文      英文     數學      總分          平均             最高            最低";
            // 
            // label_tts
            // 
            this.label_tts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_tts.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_tts.Location = new System.Drawing.Point(153, 300);
            this.label_tts.Name = "label_tts";
            this.label_tts.Size = new System.Drawing.Size(381, 107);
            this.label_tts.TabIndex = 15;
            // 
            // button_addr
            // 
            this.button_addr.Location = new System.Drawing.Point(24, 221);
            this.button_addr.Name = "button_addr";
            this.button_addr.Size = new System.Drawing.Size(123, 40);
            this.button_addr.TabIndex = 16;
            this.button_addr.Text = "加入隨機資料";
            this.button_addr.UseVisualStyleBackColor = true;
            this.button_addr.Click += new System.EventHandler(this.button_addr_Click);
            // 
            // button_result
            // 
            this.button_result.Enabled = false;
            this.button_result.Location = new System.Drawing.Point(24, 267);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(123, 40);
            this.button_result.TabIndex = 17;
            this.button_result.Text = "各科統計";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(24, 325);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(123, 40);
            this.button_reset.TabIndex = 18;
            this.button_reset.Text = "重設";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_ran20
            // 
            this.button_ran20.Location = new System.Drawing.Point(24, 371);
            this.button_ran20.Name = "button_ran20";
            this.button_ran20.Size = new System.Drawing.Size(123, 40);
            this.button_ran20.TabIndex = 19;
            this.button_ran20.Text = "隨機二十筆資料";
            this.button_ran20.UseVisualStyleBackColor = true;
            this.button_ran20.Click += new System.EventHandler(this.button_ran20_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(153, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(411, 253);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // label_scroe
            // 
            this.label_scroe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_scroe.Font = new System.Drawing.Font("新細明體", 9F);
            this.label_scroe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_scroe.Location = new System.Drawing.Point(153, 32);
            this.label_scroe.Name = "label_scroe";
            this.label_scroe.Size = new System.Drawing.Size(386, 253);
            this.label_scroe.TabIndex = 14;
            // 
            // Student_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 417);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_ran20);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_addr);
            this.Controls.Add(this.label_tts);
            this.Controls.Add(this.label_scroe);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_ma);
            this.Controls.Add(this.label_en);
            this.Controls.Add(this.lable_ch);
            this.Controls.Add(this.textBox_ma);
            this.Controls.Add(this.textBox_en);
            this.Controls.Add(this.textBox_ch);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label_n);
            this.Controls.Add(this.button_add);
            this.Name = "Student_grade";
            this.Text = "Student_grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_ch;
        private System.Windows.Forms.TextBox textBox_en;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label lable_ch;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.Label label_ma;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_tts;
        private System.Windows.Forms.Button button_addr;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_ran20;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_scroe;
    }
}