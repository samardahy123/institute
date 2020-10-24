using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute.BL
{
    class CLS_lectures
    {
        public DataTable GetAllLec()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllLec", null);
            DAL.Close();
            return dt;
        }
        public DataTable add_lectures(string lec_day, string lec_start, string lec_end, string year_name,
                                      int lev_id, int sem_id, int sub_id, int dept_id, int clas_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@lec_day", SqlDbType.NVarChar, 50);
            param[0].Value = lec_day;

            param[1] = new SqlParameter("@lec_start ", SqlDbType.NVarChar, 100);
            param[1].Value = lec_start;
            param[2] = new SqlParameter("@lec_end", SqlDbType.NVarChar, 100);
            param[2].Value = lec_end;
            param[3] = new SqlParameter("@year_name", SqlDbType.VarChar, 100);
            param[3].Value = year_name;
            param[4] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[4].Value = lev_id;
            param[5] = new SqlParameter("@sem_id", SqlDbType.VarChar, 100);
            param[5].Value = sem_id;
            param[6] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[6].Value = sub_id;
            param[7] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[7].Value = dept_id;
            param[8] = new SqlParameter("@clas_id", SqlDbType.Int);
            param[8].Value = clas_id;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_lectures", param);
            DAL.Close();
            return dt;
        }

        public DataTable UpdateLecTale(int id,string lec_day, string lec_start, string lec_end, string year_name,
                                      int lev_id, int sem_id, int sub_id, int dept_id, int clas_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@lec_day", SqlDbType.NVarChar, 50);
            param[1].Value = lec_day;

            param[2] = new SqlParameter("@lec_start ", SqlDbType.NVarChar, 100);
            param[2].Value = lec_start;
            param[3] = new SqlParameter("@lec_end", SqlDbType.NVarChar, 100);
            param[3].Value = lec_end;
            param[4] = new SqlParameter("@year_name", SqlDbType.VarChar, 100);
            param[4].Value = year_name;
            param[5] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[5].Value = lev_id;
            param[6] = new SqlParameter("@sem_id", SqlDbType.VarChar, 100);
            param[6].Value = sem_id;
            param[7] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[7].Value = sub_id;
            param[8] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[8].Value = dept_id;
            param[9] = new SqlParameter("@clas_id", SqlDbType.Int);
            param[9].Value = clas_id;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateLecTale", param);
            DAL.Close();
            return dt;
        }

        public DataTable lecture_table_for_dept(int clas_id, int lev_id, int sem_num, int dept_id)
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

            dt = DAL.SelectData("lecture_table_for_dept", param);
            DAL.Close();
            return dt;
        }

        public DataTable DelLec(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@lec_id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("DelLec", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable SearchLec(int dept, int lev, int sem)
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
            dt = DAL.SelectData("SearchLec1", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable VerifiedLecTable(string day, string lec_start, string year_name, int sub,int dept, int lev, int sem,int clas)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("@lec_day", SqlDbType.NVarChar,50);
            parameters[0].Value = day;


            parameters[1] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[1].Value = sub;

            parameters[2] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[2].Value = dept;

            parameters[3] = new SqlParameter("@clas_id", SqlDbType.Int);
            parameters[3].Value = clas;

            parameters[4] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[4].Value = lev;

            parameters[5] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[5].Value = sem;
            parameters[6] = new SqlParameter("@lec_start", SqlDbType.NVarChar,100);
            parameters[6].Value = lec_start;

            parameters[7] = new SqlParameter("@year_name", SqlDbType.NVarChar, 100);
            parameters[7].Value = year_name;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifiedLecTable", parameters);
            DAL.Close();
            return dt;
        }

        //GetDeptFromLecTable
        public int GetDeptFromLecTable(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptFromLecTable", parameters);
            DAL.Close();
            return dt;
        }
        //GetLevFromLecTable
        public int GetLevFromLecTable(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetLevFromLecTable", parameters);
            DAL.Close();
            return dt;
        }
        //GetSemFromLecTable
        public int GetSemFromLecTable(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSemFromLecTable", parameters);
            DAL.Close();
            return dt;
        }
        //GetSubFromLecTable
        public int GetSubFromLecTable(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSubFromLecTable", parameters);
            DAL.Close();
            return dt;
        }



    }
}
