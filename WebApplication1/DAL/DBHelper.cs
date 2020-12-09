using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.DAL
{
    public static class DBHelper
    {
       static  string sql = $"Data Source=.;Initial Catalog=DB_DataSet;Integrated Security=True";

        public static DataTable GetDataTable(string strsql)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter Sda = new SqlDataAdapter(strsql, conn);
                Sda.Fill(dt);
                return dt;
            }
        }

        public static int CMD(string strsql)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand Scm = new SqlCommand(strsql, conn);
                return Scm.ExecuteNonQuery();
            }
        }

        public static object User(string sqlstr)
        {
            using (SqlConnection conn = new SqlConnection(sql))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sqlstr, conn);
                return com.ExecuteScalar();
            }
        }
    }
}