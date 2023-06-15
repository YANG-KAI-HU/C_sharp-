namespace C_sharp作業
{
    partial class caculate
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label______ = new System.Windows.Forms.Label();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttondivided = new System.Windows.Forms.Button();
            this.buttontimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(144, 54);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("新細明體", 16F);
            this.labelA.Location = new System.Drawing.Point(59, 54);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(69, 22);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "數字A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("新細明體", 16F);
            this.labelB.Location = new System.Drawing.Point(59, 97);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(68, 22);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "數字B";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(144, 97);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(69, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "結果";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label______
            // 
            this.label______.AutoSize = true;
            this.label______.Font = new System.Drawing.Font("新細明體", 16F);
            this.label______.Location = new System.Drawing.Point(69, 129);
            this.label______.Name = "label______";
            this.label______.Size = new System.Drawing.Size(206, 22);
            this.label______.TabIndex = 6;
            this.label______.Text = "----------------------------";
            // 
            // buttonplus
            // 
            this.buttonplus.Location = new System.Drawing.Point(284, 54);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(75, 23);
            this.buttonplus.TabIndex = 7;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Location = new System.Drawing.Point(284, 95);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(75, 23);
            this.buttonminus.TabIndex = 8;
            this.buttonminus.Text = "-";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttondivided
            // 
            this.buttondivided.Location = new System.Drawing.Point(281, 183);
            this.buttondivided.Name = "buttondivided";
            this.buttondivided.Size = new System.Drawing.Size(75, 23);
            this.buttondivided.TabIndex = 9;
            this.buttondivided.Text = "/";
            this.buttondivided.UseVisualStyleBackColor = true;
            this.buttondivided.Click += new System.EventHandler(this.buttondivided_Click);
            // 
            // buttontimes
            // 
            this.buttontimes.Location = new System.Drawing.Point(281, 142);
            this.buttontimes.Name = "buttontimes";
            this.buttontimes.Size = new System.Drawing.Size(75, 23);
            this.buttontimes.TabIndex = 10;
            this.buttontimes.Text = "*";
            this.buttontimes.UseVisualStyleBackColor = true;
            this.buttontimes.Click += new System.EventHandler(this.buttontimes_Click);
            // 
            // caculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 269);
            this.Controls.Add(this.buttontimes);
            this.Controls.Add(this.buttondivided);
            this.Controls.Add(this.buttonminus);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.label______);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Name = "caculate";
            this.Text = "caculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label______;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttondivided;
        private System.Windows.Forms.Button buttontimes;
    }
}