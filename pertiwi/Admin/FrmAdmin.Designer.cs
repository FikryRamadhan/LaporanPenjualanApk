namespace pertiwi.Admin
{
    partial class FrmAdmin
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKelolaLaporan = new System.Windows.Forms.Button();
            this.buttonKelolaUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.buttonLogout);
            this.pnlMenu.Controls.Add(this.buttonKelolaLaporan);
            this.pnlMenu.Controls.Add(this.buttonKelolaUser);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 450);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.MintCream;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.Location = new System.Drawing.Point(28, 324);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(140, 49);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonKelolaLaporan
            // 
            this.buttonKelolaLaporan.BackColor = System.Drawing.Color.MintCream;
            this.buttonKelolaLaporan.FlatAppearance.BorderSize = 0;
            this.buttonKelolaLaporan.Location = new System.Drawing.Point(28, 269);
            this.buttonKelolaLaporan.Name = "buttonKelolaLaporan";
            this.buttonKelolaLaporan.Size = new System.Drawing.Size(140, 49);
            this.buttonKelolaLaporan.TabIndex = 5;
            this.buttonKelolaLaporan.Text = "Kelola Laporan";
            this.buttonKelolaLaporan.UseVisualStyleBackColor = false;
            this.buttonKelolaLaporan.Click += new System.EventHandler(this.buttonKelolaLaporan_Click);
            // 
            // buttonKelolaUser
            // 
            this.buttonKelolaUser.BackColor = System.Drawing.Color.MintCream;
            this.buttonKelolaUser.FlatAppearance.BorderSize = 0;
            this.buttonKelolaUser.Location = new System.Drawing.Point(28, 214);
            this.buttonKelolaUser.Name = "buttonKelolaUser";
            this.buttonKelolaUser.Size = new System.Drawing.Size(140, 49);
            this.buttonKelolaUser.TabIndex = 4;
            this.buttonKelolaUser.Text = "Kelola User";
            this.buttonKelolaUser.UseVisualStyleBackColor = false;
            this.buttonKelolaUser.Click += new System.EventHandler(this.buttonKelolaUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pertiwi.Properties.Resources.logoXyz;
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(200, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(600, 70);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kelola Laporan";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 380);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button buttonKelolaLaporan;
        private System.Windows.Forms.Button buttonKelolaUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label lblTitle;
    }
}