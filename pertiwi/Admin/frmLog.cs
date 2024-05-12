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
    public partial class frmLog : Form
    {
        SqlConnection OsqlConn = null;

        public frmLog(SqlConnection _OSqlConn)
        {
            InitializeComponent();

            OsqlConn = _OSqlConn;

            dataGridView1.DataSource = CommonClass.dtLoadData(OsqlConn, "select * from tbl_log");
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
