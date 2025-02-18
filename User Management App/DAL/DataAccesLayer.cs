using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Management_App.DAL
{
    internal class DataAccesLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public DataAccesLayer()
        {
            con = new SqlConnection(@"Server =.; DataBase = UserTestDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }
        public DataTable SelectData(string Stored_Procuder, SqlParameter[] param)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procuder;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        public void ExecutData(string Stored_Procuder, SqlParameter[] param)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procuder;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
