namespace pertiwi.Admin
{
    partial class frmLog
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
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(12, 9);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(68, 13);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Pilih Tanggal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.Location = new System.Drawing.Point(168, 25);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(111, 23);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTanggal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLog";
            this.Text = "frmLog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}