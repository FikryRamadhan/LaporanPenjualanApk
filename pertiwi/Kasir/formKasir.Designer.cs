namespace pertiwi.Kasir
{
    partial class formKasir
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonButton = new System.Windows.Forms.Button();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtrx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdbrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgsatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textHargaSatuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textQuantitas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTotalBiaya = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.buttonSimpan);
            this.pnlContent.Controls.Add(this.buttonButton);
            this.pnlContent.Controls.Add(this.buttonBayar);
            this.pnlContent.Controls.Add(this.textBox1);
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.dataGridView1);
            this.pnlContent.Controls.Add(this.buttonReset);
            this.pnlContent.Controls.Add(this.btnTambah);
            this.pnlContent.Controls.Add(this.comboBoxMenu);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.textHargaSatuan);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.textQuantitas);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.textTotalBiaya);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 450);
            this.pnlContent.TabIndex = 5;
            this.pnlContent.TabStop = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSimpan.Location = new System.Drawing.Point(644, 368);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(119, 27);
            this.buttonSimpan.TabIndex = 44;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonButton
            // 
            this.buttonButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonButton.Location = new System.Drawing.Point(509, 368);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(129, 27);
            this.buttonButton.TabIndex = 43;
            this.buttonButton.Text = "Print";
            this.buttonButton.UseVisualStyleBackColor = false;
            // 
            // buttonBayar
            // 
            this.buttonBayar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBayar.Location = new System.Drawing.Point(225, 399);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(178, 27);
            this.buttonBayar.TabIndex = 42;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = false;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(225, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 23);
            this.textBox1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total Biaya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Keranjang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtrx,
            this.kdbrg,
            this.nmbrg,
            this.hrgsatuan,
            this.quantity,
            this.subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(227, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 113);
            this.dataGridView1.TabIndex = 38;
            // 
            // idtrx
            // 
            this.idtrx.HeaderText = "ID TRANSAKSI";
            this.idtrx.Name = "idtrx";
            this.idtrx.ReadOnly = true;
            // 
            // kdbrg
            // 
            this.kdbrg.HeaderText = "Kode Barang";
            this.kdbrg.Name = "kdbrg";
            this.kdbrg.ReadOnly = true;
            // 
            // nmbrg
            // 
            this.nmbrg.HeaderText = "Nama Barang";
            this.nmbrg.Name = "nmbrg";
            this.nmbrg.ReadOnly = true;
            // 
            // hrgsatuan
            // 
            this.hrgsatuan.HeaderText = "Harga Satuan";
            this.hrgsatuan.Name = "hrgsatuan";
            this.hrgsatuan.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.Location = new System.Drawing.Point(644, 190);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 27);
            this.buttonReset.TabIndex = 37;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTambah.Location = new System.Drawing.Point(509, 190);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(129, 27);
            this.btnTambah.TabIndex = 36;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(222, 98);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(229, 24);
            this.comboBoxMenu.TabIndex = 35;
            this.comboBoxMenu.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMenu_SelectionChangeCommitted);
            this.comboBoxMenu.Click += new System.EventHandler(this.comboBoxMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pilih Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Harga Satuan";
            // 
            // textHargaSatuan
            // 
            this.textHargaSatuan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textHargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHargaSatuan.Location = new System.Drawing.Point(222, 155);
            this.textHargaSatuan.Multiline = true;
            this.textHargaSatuan.Name = "textHargaSatuan";
            this.textHargaSatuan.Size = new System.Drawing.Size(229, 29);
            this.textHargaSatuan.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantitas";
            // 
            // textQuantitas
            // 
            this.textQuantitas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textQuantitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuantitas.Location = new System.Drawing.Point(509, 98);
            this.textQuantitas.Multiline = true;
            this.textQuantitas.Name = "textQuantitas";
            this.textQuantitas.Size = new System.Drawing.Size(249, 29);
            this.textQuantitas.TabIndex = 26;
            this.textQuantitas.TextChanged += new System.EventHandler(this.textQuantitas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Harga";
            // 
            // textTotalBiaya
            // 
            this.textTotalBiaya.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textTotalBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalBiaya.Location = new System.Drawing.Point(512, 155);
            this.textTotalBiaya.Multiline = true;
            this.textTotalBiaya.Name = "textTotalBiaya";
            this.textTotalBiaya.Size = new System.Drawing.Size(246, 29);
            this.textTotalBiaya.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(663, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kasir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(241, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Form Transaksi";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.buttonLogout);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 450);
            this.pnlMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kasir";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pertiwi.Properties.Resources.logoXyz;
            this.pictureBox1.Location = new System.Drawing.Point(38, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formKasir";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHargaSatuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQuantitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTotalBiaya;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonButton;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrx;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdbrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgsatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}