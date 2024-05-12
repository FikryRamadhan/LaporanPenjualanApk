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
    public partial class FrmAdmin : Form
    {
        SqlConnection oSqlConn = null;

        private Form activeForm;

        public FrmAdmin(SqlConnection _OsqlConn)
        {
            InitializeComponent();

            oSqlConn = _OsqlConn;

            OpenChildForm(new frmLog(oSqlConn), null);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(childForm);
            this.pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.lblTitle.Text = childForm.Text;
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKelolaUser_Click(object sender, EventArgs e)
        {

            OpenChildForm(new pertiwi.Admin.formKelolaUser(oSqlConn), null);
        }

        private void buttonKelolaLaporan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pertiwi.Admin.formKelolaLaporan(oSqlConn), null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pertiwi.Admin.frmLog(oSqlConn), null);
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CommonClass.saveLog(oSqlConn, InfoUser.idUser, InfoUser.username, "Log Out");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
