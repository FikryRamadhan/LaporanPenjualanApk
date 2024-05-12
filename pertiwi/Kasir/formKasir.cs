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

namespace pertiwi.Kasir
{
    public partial class formKasir : Form
    {
        SqlConnection oSqlConn = null;

        public formKasir(SqlConnection _oSqlConn)
        {
            InitializeComponent();

            oSqlConn = _oSqlConn;
        }

        private void comboBoxMenu_Click(object sender, EventArgs e)
        {
            DataTable dt = CommonClass.dtLoadData(oSqlConn, "SELECT kode_barang, nama_barang FROM tbl_barang");

            comboBoxMenu.DataSource = dt;
            comboBoxMenu.DisplayMember = "nama_barang";
            comboBoxMenu.ValueMember = "kode_barang";

            comboBoxMenu.SelectedIndex = -1;
        }

        private void comboBoxMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedIndex > -1)
            {
                DataTable dt = CommonClass.dtLoadData(oSqlConn, "SELECT harga_satuan FROM tbl_barang WHERE kode_barang ='" + comboBoxMenu.SelectedValue + "'");

                textHargaSatuan.Text = dt.Rows[0]["harga_satuan"].ToString();


                //MessageBox.Show(comboBoxMenu.Text);

            }
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string[] row = new string[]
            {
                "TRX001",
                comboBoxMenu.SelectedValue.ToString(),
                comboBoxMenu.Text.ToString(),
                textHargaSatuan.Text.ToString(),
                textQuantitas.Text.ToString(),
                textTotalBiaya.Text.ToString(),
            };

            dataGridView1.Rows.Add(row);
        }

        private void textQuantitas_TextChanged(object sender, EventArgs e)
        {
            if(textQuantitas.Text.Length > 0)
            {
                string quantitas = textQuantitas.Text;
                string hargaAwal = textHargaSatuan.Text;

                int subtotal = Convert.ToInt32(quantitas) * Convert.ToInt32(hargaAwal);

                textTotalBiaya.Text = subtotal.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }


        /*
         For Simpan Data Transaksi
         */
        public static bool saveTransaksi(SqlConnection oSqlConn , string _noTransaksi, DateTime _tglTransaksi, int _totalBayar, int _idUser, int _idBarang)
        {
            bool isvalid = false;

            try
            {

                using (SqlCommand Ocmd = new SqlCommand("spInsertTransaksi", oSqlConn))
                {
                    // Menyesuaikan Dengan Sp / Storage Prosedure
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@noTransaksi", SqlDbType.NVarChar).Value = _noTransaksi;
                    Ocmd.Parameters.Add("@tglTransaksi", SqlDbType.DateTime).Value = _tglTransaksi;
                    Ocmd.Parameters.Add("@totalBayar", SqlDbType.BigInt).Value = _totalBayar;
                    Ocmd.Parameters.Add("@idUser", SqlDbType.BigInt).Value = _idUser;
                    Ocmd.Parameters.Add("@idBarang", SqlDbType.BigInt).Value = _idBarang;

                    if (oSqlConn.State != ConnectionState.Open) oSqlConn.Open();

                    Ocmd.ExecuteNonQuery();

                    isvalid = true;
                }

            } catch (Exception ex) 
            { 
                isvalid = false;
            }

            return isvalid;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                     
                    if (dr.Cells["idTrx"].Value != null)
                    {
                        string idTrx = dr.Cells["idTrx"].Value.ToString();
                        string TotalBayar = dr.Cells["subtotal"].Value.ToString();
                        string idUser = this.ToString();
                        string kodeBarang = dr.Cells["kdBrg"].Value.ToString();
                        string idBarang = CommonClass.getSingleData(oSqlConn, "SELECT ID FROM tbl_barang WHERE kode_barang ='" + kodeBarang + "'");


                        if (saveTransaksi(oSqlConn, idTrx, DateTime.Now, Convert.ToInt32(TotalBayar), 1, Convert.ToInt32(idBarang)))
                        {
                            MessageBox.Show("Data Transaksi Berhasil Disimpan");
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
