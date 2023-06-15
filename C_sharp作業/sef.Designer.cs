namespace C_sharp作業
{
    partial class sef
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sef));
            this.Cnmbox = new System.Windows.Forms.TextBox();
            this.Enmbox = new System.Windows.Forms.TextBox();
            this.sexbox = new System.Windows.Forms.TextBox();
            this.starbox = new System.Windows.Forms.TextBox();
            this.Cname = new System.Windows.Forms.Label();
            this.Ename = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.Label();
            this.hibtm = new System.Windows.Forms.Button();
            this.helbtm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cnmbox
            // 
            this.Cnmbox.Location = new System.Drawing.Point(241, 27);
            this.Cnmbox.Name = "Cnmbox";
            this.Cnmbox.Size = new System.Drawing.Size(100, 22);
            this.Cnmbox.TabIndex = 0;
            // 
            // Enmbox
            // 
            this.Enmbox.Location = new System.Drawing.Point(241, 56);
            this.Enmbox.Name = "Enmbox";
            this.Enmbox.Size = new System.Drawing.Size(100, 22);
            this.Enmbox.TabIndex = 1;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(241, 88);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 22);
            this.sexbox.TabIndex = 2;
            // 
            // starbox
            // 
            this.starbox.Location = new System.Drawing.Point(241, 116);
            this.starbox.Name = "starbox";
            this.starbox.Size = new System.Drawing.Size(100, 22);
            this.starbox.TabIndex = 3;
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Font = new System.Drawing.Font("新細明體", 14F);
            this.Cname.Location = new System.Drawing.Point(151, 30);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(66, 19);
            this.Cname.TabIndex = 4;
            this.Cname.Text = "中文名";
            // 
            // Ename
            // 
            this.Ename.AutoSize = true;
            this.Ename.Font = new System.Drawing.Font("新細明體", 14F);
            this.Ename.Location = new System.Drawing.Point(151, 59);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(66, 19);
            this.Ename.TabIndex = 5;
            this.Ename.Text = "英文名";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("新細明體", 14F);
            this.sex.Location = new System.Drawing.Point(170, 88);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(47, 19);
            this.sex.TabIndex = 6;
            this.sex.Text = "性別";
            // 
            // star
            // 
            this.star.AutoSize = true;
            this.star.Font = new System.Drawing.Font("新細明體", 14F);
            this.star.Location = new System.Drawing.Point(170, 119);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(47, 19);
            this.star.TabIndex = 7;
            this.star.Text = "星座";
            // 
            // hibtm
            // 
            this.hibtm.Location = new System.Drawing.Point(255, 144);
            this.hibtm.Name = "hibtm";
            this.hibtm.Size = new System.Drawing.Size(86, 32);
            this.hibtm.TabIndex = 8;
            this.hibtm.Text = "Say hi";
            this.hibtm.UseVisualStyleBackColor = true;
            this.hibtm.Click += new System.EventHandler(this.hibtm_Click);
            // 
            // helbtm
            // 
            this.helbtm.Location = new System.Drawing.Point(255, 182);
            this.helbtm.Name = "helbtm";
            this.helbtm.Size = new System.Drawing.Size(86, 32);
            this.helbtm.TabIndex = 9;
            this.helbtm.Text = "Say hello";
            this.helbtm.UseVisualStyleBackColor = true;
            this.helbtm.Click += new System.EventHandler(this.helbtm_Click);
            // 
            // 自我介紹
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 276);
            this.Controls.Add(this.helbtm);
            this.Controls.Add(this.hibtm);
            this.Controls.Add(this.star);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.Ename);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.starbox);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.Enmbox);
            this.Controls.Add(this.Cnmbox);
            this.Name = "自我介紹";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cnmbox;
        private System.Windows.Forms.TextBox Enmbox;
        private System.Windows.Forms.TextBox sexbox;
        private System.Windows.Forms.TextBox starbox;
        private System.Windows.Forms.Label Cname;
        private System.Windows.Forms.Label Ename;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label star;
        private System.Windows.Forms.Button hibtm;
        private System.Windows.Forms.Button helbtm;
    }
}

