using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NadLan
{
    public class DbContext
    {
        public string sql { get; set; }
        public string constr { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlConnection con { get; set; }
        public DbContext()
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\AgentsDb.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);
            Open();

        }
        public DataTable Excute(string sql)
        {
            cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExcutenonQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            return cmd.ExecuteNonQuery();
        }
        public void Open()
        {
            con.Open();
        }
        public void Close()
        {
            con.Close();
        }
    }
}