using pertiwi.Admin;
using pertiwi.Gudang;
using pertiwi.Kasir;
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

namespace pertiwi
{
    public partial class Login : Form
    {

        SqlConnection oSqlConn = null;

        public Login()
        {
            InitializeComponent();
            string sConnString = "server=DESKTOP-EQMDM8D\\SQLEXPRESS;database=XYZSTORE;uid=sa;pwd=Admin123; MultipleActiveResultSets=true;";
            oSqlConn = new SqlConnection(sConnString);
            oSqlConn.Open();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = CommonClass.dtLoadData(oSqlConn, "SELECT * FROM tbl_users WHERE username='"+ textUser.Text +"' AND password='"+ textPassword.Text +"'");

            if (dt.Rows[0]["type_user"].ToString() == "Admin")
            {
                InfoUser.idUser = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                InfoUser.username = dt.Rows[0]["username"].ToString();
                CommonClass.saveLog(oSqlConn, InfoUser.idUser, InfoUser.username, "Login");
                FrmAdmin admin = new FrmAdmin(oSqlConn);
                admin.Show();
                this.Hide();
            }
            else if (dt.Rows[0]["type_user"].ToString() == "Gudang")
            {
                InfoUser.idUser = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                InfoUser.username = dt.Rows[0]["username"].ToString();
                CommonClass.saveLog(oSqlConn, InfoUser.idUser, InfoUser.username, "Login");
                formGudang gudang = new formGudang(oSqlConn);
                gudang.Show();
                this.Hide();
            }
            else if (dt.Rows[0]["type_user"].ToString() == "Kasir")
            {
                InfoUser.idUser = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                InfoUser.username = dt.Rows[0]["username"].ToString();
                CommonClass.saveLog(oSqlConn, InfoUser.idUser, InfoUser.username, "Login");
                formKasir kasir = new formKasir(oSqlConn);
                kasir.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("User Tidak Valid");
            }
        }



    }
}
