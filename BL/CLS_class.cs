using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Institute.BL
{
    class CLS_class
    {
        public DataTable allclasses()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("allclasses", null);
            DAL.Close();
            return dt;
        }

        public DataTable add_class(string class_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@class_name", SqlDbType.NVarChar, 100);
            param[0].Value =class_name;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_class", param);
            DAL.Close();
            return dt;
        }

        public DataTable UpdateClass(int id,string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            param[1].Value = name;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateClass", param);
            DAL.Close();
            return dt;
        }


        public DataTable DelClass(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("DelClass", param);
            DAL.Close();
            return dt;
        }

    }
}
