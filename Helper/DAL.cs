using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace rest_api.Helper
{
    public class DAL
    {
        private static SqlConnection sqlcon= new SqlConnection(ConfigurationManager.ConnectionStrings["Main"].ConnectionString);
        public DAL()
        {
        }

        public static DataTable Select(string query)
        {
            var da = new SqlDataAdapter();
            var cmd = sqlcon.CreateCommand();
            cmd.CommandText = query;
            da.SelectCommand = cmd;
            var ds = new DataSet();
            sqlcon.Open();
            da.Fill(ds);
            sqlcon.Close();
            return ds.Tables[0];
        }
    }
}