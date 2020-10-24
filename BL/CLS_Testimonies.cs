using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute.BL
{
    class CLS_Testimonies
    {

        public DataTable add_Testimonies(string test_type, int stu_id, string stu_name)
        {
           
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@test_type", SqlDbType.NVarChar, 100);
        param[0].Value =test_type;
            param[1] = new SqlParameter("@stu_id", SqlDbType.Int);
            param[1].Value = stu_id;
            param[2] = new SqlParameter("@stu_name", SqlDbType.NVarChar, 200);
            param[2].Value = test_type;
            DAL.Open();
            DataTable dt = new DataTable();
        dt = DAL.SelectData("add_Testimonies", param);
            DAL.Close();
            return dt;
        }
        public DataTable getall_stu_info_bycode(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@code", SqlDbType.NVarChar,100);
            param[0].Value = code;

            dt = DAL.SelectData("getall_stu_info_bycode", param);
            DAL.Close();
            return dt;
        }

        public DataTable GetAllExam2 (string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@code", SqlDbType.NVarChar, 100);
            param[0].Value = code;

            dt = DAL.SelectData("GetAllExam2", param);
            DAL.Close();
            return dt;
        }
    }
}
