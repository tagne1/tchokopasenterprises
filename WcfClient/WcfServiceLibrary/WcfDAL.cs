using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WcfServiceLibrary
{
    class WcfDAL
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        //DataSet ds;
        public static SqlConnection Connection()
        {
            string s = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;
        }
        public bool DML(string Query)
        {
            cmd = new SqlCommand(Query, WcfDAL.Connection());
            int x = cmd.ExecuteNonQuery();
            if (x == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Getdata(string query)
        {
            da = new SqlDataAdapter(query, WcfDAL.Connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
