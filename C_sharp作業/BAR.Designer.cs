namespace C_sharp作業
{
    partial class BAR
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
            this.totlemoney = new System.Windows.Forms.Label();
            this.labelmenu = new System.Windows.Forms.Label();
            this.moneycountlabel = new System.Windows.Forms.Label();
            this.comboBox_gun = new System.Windows.Forms.ComboBox();
            this.textBox_gun = new System.Windows.Forms.TextBox();
            this.itemnum = new System.Windows.Forms.Label();
            this.checkoutbtn = new System.Windows.Forms.Button();
            this.labellist = new System.Windows.Forms.Label();
            this.itemlist = new System.Windows.Forms.Label();
            this.cleanbtn = new System.Windows.Forms.Button();
            this.paylabel = new System.Windows.Forms.Label();
            this.CredBtn = new System.Windows.Forms.Button();
            this.facepaybtn = new System.Windows.Forms.Button();
            this.pictureBox_gun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gun)).BeginInit();
            this.SuspendLayout();
            // 
            // totlemoney
            // 
            this.totlemoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totlemoney.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.totlemoney.Location = new System.Drawing.Point(513, 22);
            this.totlemoney.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.totlemoney.Name = "totlemoney";
            this.totlemoney.Size = new System.Drawing.Size(220, 86);
            this.totlemoney.TabIndex = 4;
            this.totlemoney.Text = "總金額:";
            // 
            // labelmenu
            // 
            this.labelmenu.BackColor = System.Drawing.Color.Transparent;
            this.labelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelmenu.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.labelmenu.Location = new System.Drawing.Point(12, 22);
            this.labelmenu.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelmenu.Size = new System.Drawing.Size(230, 359);
            this.labelmenu.TabIndex = 1;
            this.labelmenu.Text = "Menu";
            // 
            // moneycountlabel
            // 
            this.moneycountlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moneycountlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneycountlabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.moneycountlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moneycountlabel.Location = new System.Drawing.Point(540, 59);
            this.moneycountlabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.moneycountlabel.Name = "moneycountlabel";
            this.moneycountlabel.Size = new System.Drawing.Size(177, 31);
            this.moneycountlabel.TabIndex = 7;
            // 
            // comboBox_gun
            // 
            this.comboBox_gun.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox_gun.FormattingEnabled = true;
            this.comboBox_gun.Items.AddRange(new object[] {
            "R-301-3000$",
            "R-99-2500$",
            "Nemesis-3400$",
            "Peacekeeper-2000$",
            "Kraber-5000$",
            "L-star-4000$"});
            this.comboBox_gun.Location = new System.Drawing.Point(43, 61);
            this.comboBox_gun.Name = "comboBox_gun";
            this.comboBox_gun.Size = new System.Drawing.Size(171, 24);
            this.comboBox_gun.TabIndex = 8;
            this.comboBox_gun.SelectedIndexChanged += new System.EventHandler(this.comboBox_gun_SelectedIndexChanged);
            // 
            // textBox_gun
            // 
            this.textBox_gun.Font = new System.Drawing.Font("新細明體", 16F);
            this.textBox_gun.Location = new System.Drawing.Point(127, 228);
            this.textBox_gun.Name = "textBox_gun";
            this.textBox_gun.Size = new System.Drawing.Size(87, 33);
            this.textBox_gun.TabIndex = 9;
            this.textBox_gun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_gun_KeyDown);
            this.textBox_gun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_gun_KeyPress);
            // 
            // itemnum
            // 
            this.itemnum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.itemnum.Location = new System.Drawing.Point(63, 231);
            this.itemnum.Name = "itemnum";
            this.itemnum.Size = new System.Drawing.Size(57, 30);
            this.itemnum.TabIndex = 10;
            this.itemnum.Text = "數量";
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Location = new System.Drawing.Point(127, 275);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(87, 41);
            this.checkoutbtn.TabIndex = 11;
            this.checkoutbtn.Text = "加入購物車";
            this.checkoutbtn.UseVisualStyleBackColor = true;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click);
            // 
            // labellist
            // 
            this.labellist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labellist.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labellist.Location = new System.Drawing.Point(251, 22);
            this.labellist.Name = "labellist";
            this.labellist.Size = new System.Drawing.Size(256, 359);
            this.labellist.TabIndex = 12;
            this.labellist.Text = "購物清單";
            // 
            // itemlist
            // 
            this.itemlist.BackColor = System.Drawing.Color.White;
            this.itemlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemlist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.itemlist.Location = new System.Drawing.Point(262, 48);
            this.itemlist.Name = "itemlist";
            this.itemlist.Size = new System.Drawing.Size(234, 291);
            this.itemlist.TabIndex = 13;
            // 
            // cleanbtn
            // 
            this.cleanbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cleanbtn.Location = new System.Drawing.Point(395, 349);
            this.cleanbtn.Margin = new System.Windows.Forms.Padding(0);
            this.cleanbtn.Name = "cleanbtn";
            this.cleanbtn.Size = new System.Drawing.Size(75, 23);
            this.cleanbtn.TabIndex = 14;
            this.cleanbtn.Text = "清空";
            this.cleanbtn.UseVisualStyleBackColor = false;
            this.cleanbtn.Click += new System.EventHandler(this.cleanbtn_Click);
            // 
            // paylabel
            // 
            this.paylabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paylabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.paylabel.Location = new System.Drawing.Point(513, 120);
            this.paylabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.paylabel.Name = "paylabel";
            this.paylabel.Size = new System.Drawing.Size(220, 141);
            this.paylabel.TabIndex = 15;
            this.paylabel.Text = "付款方式";
            // 
            // CredBtn
            // 
            this.CredBtn.Location = new System.Drawing.Point(522, 184);
            this.CredBtn.Name = "CredBtn";
            this.CredBtn.Size = new System.Drawing.Size(87, 41);
            this.CredBtn.TabIndex = 16;
            this.CredBtn.Text = "信用卡(九折)";
            this.CredBtn.UseVisualStyleBackColor = true;
            this.CredBtn.Click += new System.EventHandler(this.CredBtn_Click);
            // 
            // facepaybtn
            // 
            this.facepaybtn.Location = new System.Drawing.Point(630, 184);
            this.facepaybtn.Name = "facepaybtn";
            this.facepaybtn.Size = new System.Drawing.Size(87, 41);
            this.facepaybtn.TabIndex = 17;
            this.facepaybtn.Text = "貨到付款";
            this.facepaybtn.UseVisualStyleBackColor = true;
            this.facepaybtn.Click += new System.EventHandler(this.facepaybtn_Click);
            // 
            // pictureBox_gun
            // 
            this.pictureBox_gun.Location = new System.Drawing.Point(43, 111);
            this.pictureBox_gun.Name = "pictureBox_gun";
            this.pictureBox_gun.Size = new System.Drawing.Size(180, 91);
            this.pictureBox_gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gun.TabIndex = 18;
            this.pictureBox_gun.TabStop = false;
            // 
            // BAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.pictureBox_gun);
            this.Controls.Add(this.facepaybtn);
            this.Controls.Add(this.CredBtn);
            this.Controls.Add(this.paylabel);
            this.Controls.Add(this.cleanbtn);
            this.Controls.Add(this.itemlist);
            this.Controls.Add(this.labellist);
            this.Controls.Add(this.checkoutbtn);
            this.Controls.Add(this.itemnum);
            this.Controls.Add(this.textBox_gun);
            this.Controls.Add(this.comboBox_gun);
            this.Controls.Add(this.moneycountlabel);
            this.Controls.Add(this.totlemoney);
            this.Controls.Add(this.labelmenu);
            this.Name = "BAR";
            this.Text = "BAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totlemoney;
        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.Label moneycountlabel;
        private System.Windows.Forms.ComboBox comboBox_gun;
        private System.Windows.Forms.TextBox textBox_gun;
        private System.Windows.Forms.Label itemnum;
        private System.Windows.Forms.Button checkoutbtn;
        private System.Windows.Forms.Label labellist;
        private System.Windows.Forms.Label itemlist;
        private System.Windows.Forms.Button cleanbtn;
        private System.Windows.Forms.Label paylabel;
        private System.Windows.Forms.Button CredBtn;
        private System.Windows.Forms.Button facepaybtn;
        private System.Windows.Forms.PictureBox pictureBox_gun;
    }
}