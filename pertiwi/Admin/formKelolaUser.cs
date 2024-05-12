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

namespace pertiwi.Admin
{
    public partial class formKelolaUser : Form
    {
        SqlConnection OsqlConn = null;
        string sId = null;

        public formKelolaUser(SqlConnection _OSqlConn)
        {
            InitializeComponent();
            OsqlConn = _OSqlConn;
            dataGridView1.DataSource = CommonClass.dtLoadData(OsqlConn, "SELECT * FROM tbl_users");
        }

        // Untuk validasi inputan

        public bool validation(out string _sMessage)
        {
            bool isvalid = false;
            string sResultMessage = "";

            try
            {
                if(!string.IsNullOrEmpty(comboBoxTypeUser.Text)) 
                {
                    if (!string.IsNullOrEmpty(textAlamat.Text))
                    {
                        if (!string.IsNullOrEmpty(textNama.Text))
                        {
                            if (!string.IsNullOrEmpty(textUsername.Text))
                            {
                                if (!string.IsNullOrEmpty(textPassword.Text))
                                {
                                    sResultMessage = "success";
                                    isvalid = true;
                                }
                                else
                                {
                                    sResultMessage = "Password Wajib Diisi";
                                    isvalid = false;
                                }
                            }
                            else
                            {
                                sResultMessage = "Username Wajib Diisi";
                                isvalid = false;
                            }
                        }
                        else
                        {
                            sResultMessage = "Nama Wajib Di Isi";
                            isvalid = false;
                        }
                    }
                    else
                    {
                        sResultMessage = "Alamat Wajib Di Isi";
                        isvalid = false;
                    }
                }
                else
                {
                    sResultMessage = "Type User Wajib Di Isi";
                    isvalid = false;
                }
            }
            catch (Exception ex)
            {
                isvalid = false;
                sResultMessage = "Gagal Menyimpan Data User";
            }

            _sMessage = sResultMessage;
            return isvalid;


        }

        // for crud
        public static bool saveUser(SqlConnection OSqlCOnn, string _typeUser, string _nama, string _alamat, string _username, string _password )
        {
            bool isvalid = false;
            try
            {
                using(SqlCommand Ocmd = new SqlCommand("spInsertUser", OSqlCOnn) ) 
                {
                    // Sql Command
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@typeuser", SqlDbType.NVarChar).Value = _typeUser;
                    Ocmd.Parameters.Add("@nama", SqlDbType.NVarChar).Value = _nama;
                    Ocmd.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = _alamat;
                    Ocmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = _username;
                    Ocmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = _password;

                    // Untuk Mengecek Koneksi Berhasil  Tidak
                    if (OSqlCOnn.State != ConnectionState.Open) OSqlCOnn.Open();

                    //Excecute Perintah Query
                    Ocmd.ExecuteNonQuery();

                    // Mengubah Nilai isvalid
                    isvalid = true;
                }
            } 
            catch(Exception ex)
            {
                isvalid = false;
            }

            return isvalid;
        }


        // Untuk Menambah Data Data
        private void Tambah_Click(object sender, EventArgs e)
        {
            string _sMessage = "";
            if (validation(out _sMessage))
            {
                if(saveUser(OsqlConn, comboBoxTypeUser.Text, textAlamat.Text, textNama.Text, textUsername.Text, textPassword.Text))
                {
                    CommonClass.saveLog(OsqlConn, InfoUser.idUser, InfoUser.username, "Menambahkan User");
                    MessageBox.Show("Tambah Data Berhasil");
                    dataGridView1.DataSource = CommonClass.dtLoadData(OsqlConn, "SELECT * FROM tbl_users");
                }
            } else
            {
                MessageBox.Show(_sMessage);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                sId = Convert.ToString(selectedRow.Cells["ID"].Value);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            CommonClass.RunQuery(OsqlConn, "DELETE tbl_users WHERE ID = '" + sId + "'");
            MessageBox.Show("Data Berhasil Di Hapus");
            dataGridView1.DataSource = CommonClass.dtLoadData(OsqlConn, "SELECT * FROM tbl_users");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Edit")
            {
                DataTable dtEdit = CommonClass.dtLoadData(OsqlConn, "SELECT * FROM tbl_users WHERE ID = '" + sId + "'");
                if (dtEdit.Rows.Count > 0)
                {
                    comboBoxTypeUser.Text = dtEdit.Rows[0]["type_user"].ToString();
                    textAlamat.Text = dtEdit.Rows[0]["alamat"].ToString();
                    textNama.Text = dtEdit.Rows[0]["nama"].ToString();
                    textUsername.Text = dtEdit.Rows[0]["username"].ToString();
                    textPassword.Text = dtEdit.Rows[0]["password"].ToString();
                    buttonEdit.Text = "Simpan";
                    
                }
            }
            else
            {
                if (editUser(OsqlConn, comboBoxTypeUser.Text, textNama.Text, textAlamat.Text, textUsername.Text, textPassword.Text, Convert.ToInt32(sId)))
                {
                    dataGridView1.DataSource = CommonClass.dtLoadData(OsqlConn, "SELECT * FROM tbl_users");
                    comboBoxTypeUser.SelectedIndex = -1;
                    textNama.Clear();
                    textAlamat.Clear();
                    textUsername.Clear();
                    textPassword.Clear();
                    MessageBox.Show("Data Berhasil Di Update");
                    buttonEdit.Text = "Edit";
                }
            }

        }

        public static bool editUser(SqlConnection OSqlCOnn,string _typeUser,  string _nama, string _alamat, string _username, string _password,int id)
        {
            bool isvalid = false;
            try
            {
                using (SqlCommand Ocmd = new SqlCommand("spEditUser", OSqlCOnn))
                {
                    // Sql Command
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                    Ocmd.Parameters.Add("@typeuser", SqlDbType.NVarChar).Value = _typeUser;
                    Ocmd.Parameters.Add("@nama", SqlDbType.NVarChar).Value = _nama;
                    Ocmd.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = _alamat;
                    Ocmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = _username;
                    Ocmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = _password;

                    // Untuk Mengecek Koneksi Berhasil  Tidak
                    if (OSqlCOnn.State != ConnectionState.Open) OSqlCOnn.Open();

                    //Excecute Perintah Query
                    Ocmd.ExecuteNonQuery();

                    // Mengubah Nilai isvalid
                    isvalid = true;
                }
            }
            catch (Exception ex)
            {
                isvalid = false;
            }

            return isvalid;
        }
    }
}
