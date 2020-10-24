using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute.BL
{
    class CLS_login
    {
        public string Type;
        
        public DataTable getAllUser()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("getallusers", null);
            DAL.Close();
            return dt;
        }
        public DataTable getusers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("getusers", null);
            DAL.Close();
            return dt;
        }
        public DataTable login(string name,string password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userr_id", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@user_password", SqlDbType.NVarChar, 100);
            param[1].Value = password;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("sp_login",param);
            DAL.Close();
            return dt;
        }
        public DataTable add_user(string name, string password,string us_type) 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@userr_name", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@user_password", SqlDbType.NVarChar, 100);
            param[1].Value = password;
            param[2] = new SqlParameter("@user_type", SqlDbType.NVarChar, 100);
            param[2].Value = us_type;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_user", param);
            DAL.Close();
            return dt;
        }
        public DataTable Updateuser(int id, string name, string password, string us_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@userr_name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            param[2] = new SqlParameter("@user_password", SqlDbType.NVarChar, 100);
            param[2].Value = password;
            param[3] = new SqlParameter("@user_type", SqlDbType.NVarChar, 100);
            param[3].Value = us_type;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Updateuser", param);
            DAL.Close();
            return dt;
        }
        public DataTable delete_user(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@userr_id", SqlDbType.Int);
            param[0].Value = id;
            
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("delete_user", param);
            DAL.Close();
            return dt;
        }
        public DataTable search_user(String criteration)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@criteration ", SqlDbType.NVarChar, 50);
            param[0].Value = criteration;
           
            dt = DAL.SelectData("search_user", param);
            DAL.Close();
            return dt;
        }
        public string GetUserType(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetUserType", parameters);
            DAL.Close();
            return dt;
        }
        public string GetUserTypeByName(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar,100);
            parameters[0].Value = name;
            string dt;
            dt = DAL.SelectDataString("GetUserTypeByName", parameters);
            DAL.Close();
            return dt;
        }
    }
}
