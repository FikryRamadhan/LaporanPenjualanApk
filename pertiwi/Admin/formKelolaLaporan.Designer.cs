namespace pertiwi.Admin
{
    partial class formKelolaLaporan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTglAwal = new System.Windows.Forms.DateTimePicker();
            this.dtpTglAkhir = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartLaporan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Awal";
            // 
            // dtpTglAwal
            // 
            this.dtpTglAwal.Location = new System.Drawing.Point(30, 30);
            this.dtpTglAwal.Name = "dtpTglAwal";
            this.dtpTglAwal.Size = new System.Drawing.Size(148, 20);
            this.dtpTglAwal.TabIndex = 1;
            // 
            // dtpTglAkhir
            // 
            this.dtpTglAkhir.Location = new System.Drawing.Point(243, 30);
            this.dtpTglAkhir.Name = "dtpTglAkhir";
            this.dtpTglAkhir.Size = new System.Drawing.Size(159, 20);
            this.dtpTglAkhir.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Akhir";            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.Location = new System.Drawing.Point(481, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(107, 25);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 153);
            this.dataGridView1.TabIndex = 5;
            // 
            // chartLaporan
            // 
            this.chartLaporan.BackColor = System.Drawing.Color.Transparent;
            this.chartLaporan.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartLaporan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLaporan.Legends.Add(legend1);
            this.chartLaporan.Location = new System.Drawing.Point(30, 244);
            this.chartLaporan.Name = "chartLaporan";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Omset";
            this.chartLaporan.Series.Add(series1);
            this.chartLaporan.Size = new System.Drawing.Size(441, 124);
            this.chartLaporan.TabIndex = 6;
            this.chartLaporan.Text = "chart1";

            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGenerate.Location = new System.Drawing.Point(371, 291);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(89, 23);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // formKelolaLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.chartLaporan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpTglAkhir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTglAwal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formKelolaLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Kelola Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTglAwal;
        private System.Windows.Forms.DateTimePicker dtpTglAkhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLaporan;
        private System.Windows.Forms.Button buttonGenerate;
    }
}