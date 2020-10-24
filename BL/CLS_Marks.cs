using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Text;

namespace Institute.BL
{
    class CLS_Marks
    {

        public DataTable add_marks(float m1, float m2, float m3, float total,
                                int stu_id, int dept_id, int lev_id, int sem_id,
                                int sub_id, string sub_deg,string year_std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@m1", SqlDbType.Float);
            param[0].Value = m1;
            param[1] = new SqlParameter("@m2", SqlDbType.Float);
            param[1].Value = m2;
            param[2] = new SqlParameter("@m3", SqlDbType.Float);
            param[2].Value = m3;
            param[3] = new SqlParameter("@stu_id", SqlDbType.Int);
            param[3].Value = stu_id;
            param[4] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[4].Value = dept_id;
            param[5] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[5].Value = lev_id;
            param[6] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[6].Value = sem_id;
            param[7] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[7].Value = sub_id;

            param[8] = new SqlParameter("@sub_total", SqlDbType.Float);
            param[8].Value = total;
            param[9] = new SqlParameter("@sub_deg", SqlDbType.NVarChar, 20);
            param[9].Value = sub_deg;
            param[10] = new SqlParameter("@year_std", SqlDbType.NVarChar, 60);
            param[10].Value = year_std;


            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_marks", param);
            DAL.Close();
            return dt;
        }

        public DataTable update_mark(int id, float m1, float m2, float m3, float total,
                                int stu_id, int dept_id, int lev_id, int sem_id,
                                int sub_id, string sub_deg,string year_std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@mark_id", SqlDbType.Float);
            param[0].Value = id;
            param[1] = new SqlParameter("@m1", SqlDbType.Float);
            param[1].Value = m1;
            param[2] = new SqlParameter("@m2", SqlDbType.Float);
            param[2].Value = m2;
            param[3] = new SqlParameter("@m3", SqlDbType.Float);
            param[3].Value = m3;
            param[4] = new SqlParameter("@stu_id", SqlDbType.Int);
            param[4].Value = stu_id;
            param[5] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[5].Value = dept_id;
            param[6] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[6].Value = lev_id;
            param[7] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[7].Value = sem_id;
            param[8] = new SqlParameter("@sub_id", SqlDbType.Int);
            param[8].Value = sub_id;

            param[9] = new SqlParameter("@sub_total", SqlDbType.Float);
            param[9].Value = total;
            param[10] = new SqlParameter("@sub_deg", SqlDbType.NVarChar, 20);
            param[10].Value = sub_deg;
            param[11] = new SqlParameter("@year_std", SqlDbType.NVarChar, 60);
            param[11].Value = year_std;


            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("update_mark", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_marksfor_dept_lev_sem(int dept, int lev, int sem,string year_std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept;


            param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[1].Value = lev;


            param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            param[2].Value = sem;

            param[3] = new SqlParameter("@year_std", SqlDbType.NVarChar,60);
            param[3].Value = year_std;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_marks1", param);
            DAL.Close();
            return dt;
        }

        //public DataTable get_marksfor_dept_lev2_sem2(int dept, int lev, int sem)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[3];

        //    param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
        //    param[0].Value = dept;


        //    param[1] = new SqlParameter("@lev_id", SqlDbType.Int);
        //    param[1].Value = lev;


        //    param[2] = new SqlParameter("@sem_id", SqlDbType.Int);
        //    param[2].Value = sem;


        //    DAL.Open();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("get_marks1forlev2sem2", param);
        //    DAL.Close();
        //    return dt;
        //}
        
        //GetSubjectFromMark
        public int GetSubjectFromMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSubjectFromMark", parameters);
            DAL.Close();
            return dt;
        }

        //GetStdFromMark
        public int GetStdFromMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetStdFromMark", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable GetStdFromMark2(int id,string year_std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            parameters[0] = new SqlParameter("@yearstd", SqlDbType.NVarChar,60);
            parameters[0].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetStdFromMark2", parameters);
            DAL.Close();
            return dt;
        }
        //GetSemFromMark
        public int GetSemFromMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSemFromMark", parameters);
            DAL.Close();
            return dt;
        }
        //GetDeptFromMark
        public int GetDeptFromMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptFromMark", parameters);
            DAL.Close();
            return dt;
        }
        //GetLevFromMark
        public int GetLevFromMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetLevFromMark", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable GetAllGraduated()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllGraduated", null);
            DAL.Close();
            return dt;
        }

        public DataTable SearchGraduteName(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar, 200);
            parameters[0].Value = name;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetGraduated", parameters);
            DAL.Close();
            return dt;
        }

        //التحقق من وجود درجات للماده
        public DataTable VerifiedMarkSTDId(int dept, int lev, int std,int sub,int sem)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@dept", SqlDbType.Int);
            parameters[0].Value = dept;
            parameters[1] = new SqlParameter("@lev", SqlDbType.Int);
            parameters[1].Value = lev;
            parameters[2] = new SqlParameter("@std", SqlDbType.Int);
            parameters[2].Value = std;
            parameters[3] = new SqlParameter("@sub", SqlDbType.Int);
            parameters[3].Value = sub;
            parameters[4] = new SqlParameter("@sem", SqlDbType.Int);
            parameters[4].Value = sem;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifiedMarkSTDId", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable GetGraduatedImg(string  name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar,200);
            parameters[0].Value = name;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetGraduatedImg", parameters);
            DAL.Close();
            return dt;
        }
        public void DelGraduated(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.ExecuteCommand("DelGraduated", parameters);
            DAL.Close();
        }
        public DataTable UpdateGraduated(string natinalId,byte[] gradImg,string totalDeg,int arrange)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            
            param[0] = new SqlParameter("@natinalId", SqlDbType.Char,14);
            param[0].Value = natinalId;

            param[1] = new SqlParameter("@gradImg", SqlDbType.Image);
            param[1].Value = gradImg;

            param[2] = new SqlParameter("@totalDeg", SqlDbType.NVarChar, 20);
            param[2].Value = totalDeg;

            param[3] = new SqlParameter("@arrange", SqlDbType.Int);
            param[3].Value = arrange;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateGraduatedForAddingGradImg", param);
            DAL.Close();
            return dt;
        }
        public void DelMark(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.ExecuteCommand("Del_mark", parameters);
            DAL.Close();
        }

    }
}
