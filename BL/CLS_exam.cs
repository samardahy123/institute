using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Institute.BL
{
    class CLS_exam
    {
  
        public DataTable add_exams( string ex_day, string ex_date, string from_time, string to_time, string year_study, int sub_id, int clas_id,int lev_id , int dept_id,int sem_id)
        {
     

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            
            param[0] = new SqlParameter("@ex_day", SqlDbType.NVarChar, 100);
            param[0].Value = ex_day;
            param[1] = new SqlParameter("@ex_date", SqlDbType.Date);
            param[1].Value = ex_date;
            param[2] = new SqlParameter("@from_time ", SqlDbType.NVarChar, 100);
            param[2].Value = from_time;
            param[3] = new SqlParameter("@to_time", SqlDbType.NVarChar, 100);
            param[3].Value = to_time;
            param[4] = new SqlParameter("@year_study", SqlDbType.VarChar, 100);
            param[4].Value = year_study;
            param[5] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[5].Value = sub_id;
            param[6] = new SqlParameter("@clas_id", SqlDbType.Int);
            param[6].Value = clas_id;
            param[7] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[7].Value = lev_id;
            param[8] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[8].Value = dept_id;
            param[9] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[9].Value = sem_id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_exams", param);
            DAL.Close();
            return dt;
        }
        public DataTable exam_table_for_dept_lev_sem(int clas_id, int lev_id, int sem_num, int dept_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@clas_id", SqlDbType.Int);
            param[0].Value = clas_id;
            param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[1].Value = lev_id;
            param[2] = new SqlParameter("@sem_num", SqlDbType.Int);
            param[2].Value = sem_num;
            param[3] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[3].Value = dept_id;

            dt = DAL.SelectData("exam_table_for_dept_lev_sem", param);
            DAL.Close();
            return dt;
        }

        public DataTable DelExam(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ex_id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("DelExam", parameters);
            DAL.Close();
            return dt;
        }


        public DataTable SearchExam(int dept, int lev, int sem)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@dept", SqlDbType.Int);
            parameters[0].Value = dept;

            parameters[1] = new SqlParameter("@lev", SqlDbType.Int);
            parameters[1].Value = lev;

            parameters[2] = new SqlParameter("@sem", SqlDbType.Int);
            parameters[2].Value = sem;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchExam", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable GetAllExam()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllExam", null);
            DAL.Close();
            return dt;
        }






    }
}
