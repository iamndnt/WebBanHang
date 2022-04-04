using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace _030422
{
    public class Ketnoi
    {
        SqlConnection con;
        private void open()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\ASP_butlearnbymyself\030422\030422\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
        }

        private void close()
        {
            if(con.State==ConnectionState.Open)
                con.Close();
        }

        public DataTable laydulieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {   
                open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
                sqlDataAdapter.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                close();
            }

            return dt;
        }
    }
}