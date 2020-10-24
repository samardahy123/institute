using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Institute.BL
{
    class CLS_Subject
    {
        public DataTable add_subjects(string sub_name, int dept_id,int lev_id,int sem_id,string instructor_name,int total_sub_full,int sub_t)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@sub_name", SqlDbType.NVarChar, 200);
            param[0].Value = sub_name;
            param[1] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[1].Value = dept_id;
            param[2] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[2].Value = lev_id;
            param[3] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[3].Value = sem_id;
            param[4] = new SqlParameter("@instrcutor_name", SqlDbType.NVarChar,50);
            param[4].Value = instructor_name;
            param[5] = new SqlParameter("@total_sub_full", SqlDbType.Int);
            param[5].Value = total_sub_full;
            param[6] = new SqlParameter("@sub_t", SqlDbType.Int);
            param[6].Value = sub_t;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_subjects", param);
            DAL.Close();
            return dt;
        }
        public DataTable UpdateSubjects(int id,string sub_name, int dept_id, int lev_id, int sem_id, string instructor_name, int total_sub_full, int sub_t)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@sub_name", SqlDbType.NVarChar, 200);
            param[1].Value = sub_name;
            param[2] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[2].Value = dept_id;
            param[3] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[3].Value = lev_id;
            param[4] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[4].Value = sem_id;
            param[5] = new SqlParameter("@instrcutor_name", SqlDbType.NVarChar, 50);
            param[5].Value = instructor_name;
            param[6] = new SqlParameter("@total_sub_full", SqlDbType.Int);
            param[6].Value = total_sub_full;
            param[7] = new SqlParameter("@sub_t", SqlDbType.Int);
            param[7].Value = sub_t;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateSubjects", param);
            DAL.Close();
            return dt;
        }
        public DataTable delet_subject( int sub_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[0].Value = sub_id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("delete_subject", param);
            DAL.Close();
            return dt;
        }
        public DataTable search_subject(String criteration)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@criteration ", SqlDbType.NVarChar, 50);
            param[0].Value = criteration;

            dt = DAL.SelectData("search_subject", param);
            DAL.Close();
            return dt;
        }
        //public DataTable getSubjectFordepartment(int dept_id,int lev_id,int sem_id)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DataTable dt = new DataTable();
        //    SqlParameter[] param = new SqlParameter[3];
        //    param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
        //    param[0].Value = dept_id;
        //    param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
        //    param[1].Value = lev_id;
        //    param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
        //    param[2].Value = sem_id;
        //    dt = DAL.SelectData("getSubjectFordepartment", param);
        //    DAL.Close();
        //    return dt;
        //}

        public DataTable getSubjectFordept_lev_sem(int dept_id, int lev_id, int sem_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept_id;
            param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[1].Value = lev_id;
            param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[2].Value = sem_id;
            dt = DAL.SelectData("getSubjectFordept_lev_sem", param);
            DAL.Close();
            return dt;
        }

        public DataTable getSubjectFordept_lev_sem2(int dept_id, int lev_id, int sem_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept_id;
            param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[1].Value = lev_id;
            param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[2].Value = sem_id;
            dt = DAL.SelectData("getSubjectFordept_lev_sem2", param);
            DAL.Close();
            return dt;
        }

        //getSubjectFordept_lev_sem_std
        public DataTable getSubjectFordept_lev_sem_std(int dept_id, int lev_id, int sem_id,int std_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept_id;
            param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[1].Value = lev_id;
            param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[2].Value = sem_id;
            param[3] = new SqlParameter("@std_id", SqlDbType.Int);
            param[3].Value = sem_id;
            dt = DAL.SelectData("getSubjectFordept_lev_sem_std", param);
            DAL.Close();
            return dt;
        }

        public DataTable select_instructorname( int sub_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[0].Value = sub_id;
            
            dt = DAL.SelectData("select_instructorname", param);
            DAL.Close();
            return dt;
        }



        public int GetSubId(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            parameters[0].Value = name;
            int dt;
            dt = DAL.SelectDataInt("GetSubIdFromSubName", parameters);
            DAL.Close();
            return dt;
        }
        public int GetTotalDegFromSubName(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetTotalDegFromSubName", parameters);
            DAL.Close();
            return dt;
        }

        public int get_sub_t(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("get_sub_t", parameters);
            DAL.Close();
            return dt;
        }


        public int GetDeptFrmSubject(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptFrmSubject", parameters);
            DAL.Close();
            return dt;
        }
        public int GetLevFrmSubject(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetLevFrmSubject", parameters);
            DAL.Close();
            return dt;
        }
        public int GetSemFrmSubject(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSemFrmSubject", parameters);
            DAL.Close();
            return dt;
        }
    }
}
