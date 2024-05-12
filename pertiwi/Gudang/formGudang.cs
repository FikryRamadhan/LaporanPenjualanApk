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

namespace pertiwi.Gudang
{
    public partial class formGudang : Form
    {
        SqlConnection oSqlConn = null;

        string sId = null;

        public formGudang(SqlConnection _oSqlConn)
        {
            InitializeComponent();

            oSqlConn = _oSqlConn;

            dataGridView1.DataSource =  CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_barang");
        }

        /*
         Untuk Create Data Barang
         */


        private void Tambah_Click(object sender, EventArgs e)
        {
            string _sMessage = "";
           
            string hargaSatuan = texthargaSatuan.Text;
            string Date = dtpDate.Text;
            string satuan =comboBoxSatuan.Text;
            string jumlahBarang = textJumlahBarang.Text;

            if (validationBarang(out _sMessage))
            {

                if (saveBarang(oSqlConn, textKodeBarang.Text, textNamaBarang.Text, Convert.ToInt32(jumlahBarang), Convert.ToDateTime(Date), satuan, Convert.ToInt32(hargaSatuan)))
                {
                    MessageBox.Show("Data Berhasil Disimpan");
                    dataGridView1.DataSource = CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_barang");
                }
            }
            else
            {
                MessageBox.Show(_sMessage);
                
            }
        }


        public static bool saveBarang(SqlConnection oSqlConn, string _kodeBarang, string _namaBarang,int _jumlahBarang, DateTime _date, string _satuan, int _hargaSatuan)
        {
            bool isvalid = false;

            try
            {

                using (SqlCommand Ocmd = new SqlCommand("spInsertBarang", oSqlConn))
                {
                    // Sql Command
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@kodeBarang", SqlDbType.NVarChar).Value = _kodeBarang;
                    Ocmd.Parameters.Add("@namaBarang", SqlDbType.NVarChar).Value = _namaBarang;
                    Ocmd.Parameters.Add("@expiredDate", SqlDbType.Date).Value = _date;
                    Ocmd.Parameters.Add("@jumlah", SqlDbType.BigInt).Value = _jumlahBarang;
                    Ocmd.Parameters.Add("@hargaSatuan", SqlDbType.BigInt).Value = _hargaSatuan;
                    Ocmd.Parameters.Add("@satuan", SqlDbType.NVarChar).Value = _satuan;


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


        // Validasi Imputan

        public bool validationBarang(out string _sMessage)
        {
            bool isvalid = false;
            string sResultMessage = "";

            try
            {

                if (!string.IsNullOrEmpty(textKodeBarang.Text))
                {
                    if(!string.IsNullOrEmpty(textNamaBarang.Text))
                    {
                        if (!string.IsNullOrEmpty(textJumlahBarang.Text))
                        {
                            if (!string.IsNullOrEmpty(textNamaBarang.Text))
                            {
                                if (!string.IsNullOrEmpty(comboBoxSatuan.Text))
                                {
                                    if (!string.IsNullOrEmpty(dtpDate.Text))
                                    {
                                        if (!string.IsNullOrEmpty(texthargaSatuan.Text))
                                        {
                                            sResultMessage = "success";
                                            isvalid = true;
                                        }
                                        else
                                        {
                                            sResultMessage = "Harga Satuan Barang Wajib Diisi";
                                            isvalid = false;
                                        }
                                    }
                                    else
                                    {
                                        sResultMessage = "Expired Barang Wajib Diisi";
                                        isvalid = false;
                                    }
                                }
                                else
                                {
                                    sResultMessage = "Satuan Barang Wajib Diisi";
                                    isvalid = false;
                                }
                            }
                            else
                            {
                                sResultMessage = "Nama Barang Wajib Diisi";
                                isvalid = false;
                            }
                        }
                        else
                        {
                            sResultMessage = "Jumlah Barang Wajib Diisi";
                            isvalid = false;
                        }
                    } else
                    {
                        sResultMessage = "Nama Barang Wajib Diisi";
                        isvalid = false;
                    }
                } else
                {
                    sResultMessage = "Kode Barang Wajib Diisi";
                    isvalid = false;
                }

            } catch (Exception ex)
            {
                sResultMessage = "Gagal Menyimpan Data Barang";
                isvalid= false;
            }

            _sMessage = sResultMessage;
            return isvalid;
        }

        /*
         Untuk Mendapatkan ID Yang Di pilih
         */

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                sId = Convert.ToString(selectedRow.Cells["ID"].Value);
            }
        }


        /*
         Edit Data
         */

        public static bool editBarang(SqlConnection oSqlConn, string _kodeBarang, string _namaBarang, int _jumlahBarang, DateTime _date, string _satuan, int _hargaSatuan, int id)
        {
            bool isvalid = false;

            try
            {

                using (SqlCommand Ocmd = new SqlCommand("spEditBarang", oSqlConn))
                {
                    // Sql Command
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    Ocmd.Parameters.Add("@kodeBarang", SqlDbType.NVarChar).Value = _kodeBarang;
                    Ocmd.Parameters.Add("@namaBarang", SqlDbType.NVarChar).Value = _namaBarang;
                    Ocmd.Parameters.Add("@expiredDate", SqlDbType.Date).Value = _date;
                    Ocmd.Parameters.Add("@jumlah", SqlDbType.BigInt).Value = _jumlahBarang;
                    Ocmd.Parameters.Add("@hargaSatuan", SqlDbType.BigInt).Value = _hargaSatuan;
                    Ocmd.Parameters.Add("@satuan", SqlDbType.NVarChar).Value = _satuan;


                    if (oSqlConn.State != ConnectionState.Open) oSqlConn.Open();

                    Ocmd.ExecuteNonQuery();

                    isvalid = true;

                }
            }
            catch (Exception ex)
            {
                isvalid = false;
            }

            return isvalid;
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Edit")
            {
                DataTable dtEdit = CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_barang WHERE ID= '" + sId +"'");

                if (dtEdit.Rows.Count > 0)
                {
                    textKodeBarang.Text = dtEdit.Rows[0]["kode_barang"].ToString();
                    textJumlahBarang.Text = dtEdit.Rows[0]["jumlah"].ToString();
                    textNamaBarang.Text = dtEdit.Rows[0]["nama_barang"].ToString();
                    comboBoxSatuan.Text = dtEdit.Rows[0]["satuan"].ToString();
                    dtpDate.Value = Convert.ToDateTime(dtEdit.Rows[0]["expired_date"]);
                    texthargaSatuan.Text = dtEdit.Rows[0]["harga_satuan"].ToString();

                    buttonEdit.Text = "Simpan";
                }

            }
            else
            {
                string hargaSatuan = texthargaSatuan.Text;
                string Date = dtpDate.Text;
                string jumlahBarang = textJumlahBarang.Text;

                if (editBarang(oSqlConn, textKodeBarang.Text, textNamaBarang.Text, Convert.ToInt32(jumlahBarang), Convert.ToDateTime(Date), comboBoxSatuan.Text, Convert.ToInt32(hargaSatuan), Convert.ToInt32(sId)))
               {
                    dataGridView1.DataSource = CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_barang");
                    comboBoxSatuan.SelectedIndex = 0;
                    textKodeBarang.Clear();
                    textJumlahBarang.Clear();
                    textNamaBarang.Clear();
                    texthargaSatuan.Clear();
                    dtpDate.DataBindings.Clear();
                    MessageBox.Show("Data Berhasil Di Perbarui");
                    buttonEdit.Text = "Edit";
                }
            }
        }

        /*
         Hapus Action
         */

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            CommonClass.RunQuery(oSqlConn, "DELETE tbl_barang WHERE ID ='" + sId + "'");
            MessageBox.Show("Data Berhasil Di Hapus");
            dataGridView1.DataSource = CommonClass.dtLoadData(oSqlConn , "SELECT * FROM tbl_barang");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_barang WHERE nama_barang LIKE '%"+ textSearch.Text + "%'");

            dataGridView1.DataSource = dt;
        }


        /*
         Action Logout User
         */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
