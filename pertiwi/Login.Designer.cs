namespace pertiwi
{
    partial class Login
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
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(284, 203);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(235, 26);
            this.textUser.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(284, 246);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(235, 26);
            this.textPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Location = new System.Drawing.Point(315, 293);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(81, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.Location = new System.Drawing.Point(410, 293);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(76, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pertiwi.Properties.Resources.logoXyz;
            this.pictureBox1.Location = new System.Drawing.Point(315, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReset;
    }
}