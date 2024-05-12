using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pertiwi.Admin
{
    public partial class formKelolaLaporan : Form
    {
        SqlConnection oSqlConn = null;

        DataTable dt = null;

        public formKelolaLaporan(SqlConnection _oSqlConn)
        {
            InitializeComponent();
            oSqlConn = _oSqlConn;

        }

        /*
         For Chart Grapict Laporan User
         */
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Membersikan Series Chart Omset
            chartLaporan.Series["Omset"].Points.Clear();

            // Mengisi Series Omset
            foreach (DataRow dr in dt.Rows)
            {
                string tgl = dr["tgl_transaksi"].ToString();
                string totalBayar = dr["total_bayar"].ToString();

                chartLaporan.Series["Omset"].Points.AddXY(tgl, totalBayar);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_transaksi WHERE tgl_transaksi BETWEEN '" + dtpTglAwal.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTglAkhir.Value.ToString("yyyy-MM-dd") + "'";

            dt = CommonClass.dtLoadData(oSqlConn, query);

            dataGridView1.DataSource = dt;
        }
    }
}
