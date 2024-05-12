namespace pertiwi.Gudang
{
    partial class formGudang
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGudang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSatuan = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.Tambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.texthargaSatuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNamaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textJumlahBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textKodeBarang = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.btnLogout);
            this.panel.Controls.Add(this.lblTitle);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 450);
            this.panel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(44, 322);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 48);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Gudang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Gudang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblGudang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblGudang
            // 
            this.lblGudang.AutoSize = true;
            this.lblGudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGudang.Location = new System.Drawing.Point(226, 9);
            this.lblGudang.Name = "lblGudang";
            this.lblGudang.Size = new System.Drawing.Size(148, 25);
            this.lblGudang.TabIndex = 1;
            this.lblGudang.Text = "Kelola Barang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBoxSatuan);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonHapus);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.Tambah);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.texthargaSatuan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textNamaBarang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textJumlahBarang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textKodeBarang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 399);
            this.panel2.TabIndex = 2;
            // 
            // comboBoxSatuan
            // 
            this.comboBoxSatuan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSatuan.FormattingEnabled = true;
            this.comboBoxSatuan.Items.AddRange(new object[] {
            "Botol",
            "KG"});
            this.comboBoxSatuan.Location = new System.Drawing.Point(325, 85);
            this.comboBoxSatuan.Name = "comboBoxSatuan";
            this.comboBoxSatuan.Size = new System.Drawing.Size(246, 24);
            this.comboBoxSatuan.TabIndex = 23;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(40, 143);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 23);
            this.dtpDate.TabIndex = 22;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textSearch.Location = new System.Drawing.Point(322, 221);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(249, 29);
            this.textSearch.TabIndex = 20;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tabel Barang";
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHapus.Location = new System.Drawing.Point(324, 183);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(127, 27);
            this.buttonHapus.TabIndex = 18;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEdit.Location = new System.Drawing.Point(182, 183);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 27);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Tambah
            // 
            this.Tambah.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tambah.Location = new System.Drawing.Point(35, 183);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(124, 27);
            this.Tambah.TabIndex = 16;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = false;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 131);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Harga Persatuan";
            // 
            // texthargaSatuan
            // 
            this.texthargaSatuan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.texthargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthargaSatuan.Location = new System.Drawing.Point(322, 143);
            this.texthargaSatuan.Multiline = true;
            this.texthargaSatuan.Name = "texthargaSatuan";
            this.texthargaSatuan.Size = new System.Drawing.Size(249, 29);
            this.texthargaSatuan.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Expired Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nama Barang";
            // 
            // textNamaBarang
            // 
            this.textNamaBarang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNamaBarang.Location = new System.Drawing.Point(35, 85);
            this.textNamaBarang.Multiline = true;
            this.textNamaBarang.Name = "textNamaBarang";
            this.textNamaBarang.Size = new System.Drawing.Size(229, 29);
            this.textNamaBarang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah Barang";
            // 
            // textJumlahBarang
            // 
            this.textJumlahBarang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textJumlahBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJumlahBarang.Location = new System.Drawing.Point(322, 28);
            this.textJumlahBarang.Multiline = true;
            this.textJumlahBarang.Name = "textJumlahBarang";
            this.textJumlahBarang.Size = new System.Drawing.Size(249, 29);
            this.textJumlahBarang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            // 
            // textKodeBarang
            // 
            this.textKodeBarang.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKodeBarang.Location = new System.Drawing.Point(35, 28);
            this.textKodeBarang.Multiline = true;
            this.textKodeBarang.Name = "textKodeBarang";
            this.textKodeBarang.Size = new System.Drawing.Size(229, 29);
            this.textKodeBarang.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pertiwi.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(543, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pertiwi.Properties.Resources.logoXyz;
            this.pictureBox1.Location = new System.Drawing.Point(44, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGudang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGudang";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGudang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texthargaSatuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNamaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJumlahBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKodeBarang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox comboBoxSatuan;
    }
}