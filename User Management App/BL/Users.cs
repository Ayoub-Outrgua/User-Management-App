using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Management_App.BL
{
    internal class Users
    {
        DAL.DataAccesLayer dal = new DAL.DataAccesLayer();

        public DataTable Get_All_Users()
        {
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Users", null);
            return dt;
        }

        public DataTable Get_Employee_Users()
        {
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_Employee_Users", null);
            return dt;
        }

        public void Add_User(string Username, string PasswordHash, string Roles)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 200);
            param[0].Value = Username;
            param[1] = new SqlParameter("@PasswordHash", SqlDbType.NVarChar, 200);
            param[1].Value = PasswordHash;
            param[2] = new SqlParameter("@Roles", SqlDbType.NVarChar, 50);
            param[2].Value = Roles;
            dal.ExecutData("Add_User", param);
        }

        public void Update_User(int UserID, string Username, string PasswordHash, string Roles)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;
            param[1] = new SqlParameter("@Username", SqlDbType.NVarChar, 200);
            param[1].Value = Username;
            param[2] = new SqlParameter("@PasswordHash", SqlDbType.NVarChar, 200);
            param[2].Value = PasswordHash;
            param[3] = new SqlParameter("@Roles", SqlDbType.NVarChar, 50);
            param[3].Value = Roles;
            dal.ExecutData("Update_User", param);
        }

        public void Delete_User(int UserID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;
            dal.ExecutData("Delete_User", param);
        }

        public DataTable Filter_Users(string Username, string Roles)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 200);
            param[0].Value = Username;
            param[1] = new SqlParameter("@Roles", SqlDbType.NVarChar, 50);
            param[1].Value = Roles;
            dt = dal.SelectData("Filter_Users", param);
            return dt;
        }
    }
}
