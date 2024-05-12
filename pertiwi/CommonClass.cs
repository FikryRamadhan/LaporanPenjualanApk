using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertiwi
{
    public class CommonClass
    {

        // Function Hapus Data
        public static void RunQuery(SqlConnection OSqlConn, string sQuery)
        {
            if (OSqlConn.State == ConnectionState.Closed)
            {
                OSqlConn.Open();
            }

            using (SqlCommand cmd = new SqlCommand(sQuery, OSqlConn))
            {
                cmd.ExecuteNonQuery();
            }
        }


        // Load Data Dari Database
        public static DataTable dtLoadData(SqlConnection oSqlConn, string sQuery)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(sQuery, oSqlConn))
            {
                using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                {
                    if (oSqlConn.State == ConnectionState.Closed) oSqlConn.Open();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        adap.Fill(dt);

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return dt;
        }


        public static string getSingleData(SqlConnection oSqlConn, string sQuery)
        {
            string sResult = null;

            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(sQuery, oSqlConn))
            {
                using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                {
                    if (oSqlConn.State == ConnectionState.Closed) oSqlConn.Open();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        adap.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            sResult= dt.Rows[0]["ID"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return sResult;
        }


        public static bool saveLog(SqlConnection oSqlConn, int id, string username, string aktifitas)
        {
            bool isvalid = false;

            try
            {

                using (SqlCommand Ocmd = new SqlCommand("spInsertLog", oSqlConn))
                {
                    // Sql Command
                    Ocmd.CommandType = CommandType.StoredProcedure;
                    Ocmd.Parameters.Add("@idUser", SqlDbType.Int).Value = id;
                    Ocmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    Ocmd.Parameters.Add("@aktifitas", SqlDbType.NVarChar).Value = aktifitas;

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

    }
}
