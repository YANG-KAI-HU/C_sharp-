namespace C_sharp作業
{
    partial class Guess_form
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
            this.button_guess = new System.Windows.Forms.Button();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.button_quit = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_guess
            // 
            this.button_guess.Font = new System.Drawing.Font("新細明體", 12F);
            this.button_guess.Location = new System.Drawing.Point(235, 129);
            this.button_guess.Name = "button_guess";
            this.button_guess.Size = new System.Drawing.Size(84, 38);
            this.button_guess.TabIndex = 0;
            this.button_guess.Text = "猜";
            this.button_guess.UseVisualStyleBackColor = true;
            this.button_guess.Click += new System.EventHandler(this.button_guess_Click);
            // 
            // textBox_num
            // 
            this.textBox_num.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox_num.Location = new System.Drawing.Point(85, 129);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(100, 36);
            this.textBox_num.TabIndex = 1;
            this.textBox_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_num_KeyPress);
            // 
            // button_quit
            // 
            this.button_quit.Font = new System.Drawing.Font("新細明體", 12F);
            this.button_quit.Location = new System.Drawing.Point(235, 201);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(84, 38);
            this.button_quit.TabIndex = 2;
            this.button_quit.Text = "Quit";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.Location = new System.Drawing.Point(76, 80);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(120, 21);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "請輸入數值";
            // 
            // Guess_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 331);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.button_guess);
            this.Name = "Guess_form";
            this.Text = "Guess_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_guess;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Label label_title;
    }
}