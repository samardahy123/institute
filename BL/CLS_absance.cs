using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Institute.BL
{
    class CLS_absance
    {

        public DataTable Get_Absance(int dept,int lev,int sem,string year_std)
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
            dt = DAL.SelectData("Get_Absance", param);
            DAL.Close();
            return dt;
        }

        public int get_sub_abs_deg(int dept, int lev, int sem, int sub_id, int stu_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[0].Value = dept;


            parameters[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[1].Value = lev;


            parameters[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[2].Value = sem;

            parameters[3] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[3].Value = sub_id;

            parameters[4] = new SqlParameter("@stu_id", SqlDbType.Int);
            parameters[4].Value = stu_id;

            int dt;
            dt = DAL.SelectDataInt("get_sub_abs_deg", parameters);
            DAL.Close();
            return dt;
        }
        

        public void add_absance(int total_lecnum_subject, int attend_num, float attend_deg, int abs_numm, float abs_deg,
            float subject_deg,
            int stu_id, int sub_id, int dept_id, int lev_id, int sem_id,
            int abs1, int abs2, int abs3, int abs4,
            int abs5, int abs6, int abs7, int abs8,
            int abs9, int abs10, int abs11, int abs12,string year_std)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[24];

            parameters[0] = new SqlParameter("@total_lecnum_subject", SqlDbType.Int);
            parameters[0].Value = total_lecnum_subject;

            parameters[1] = new SqlParameter("@attend_num", SqlDbType.Int);
            parameters[1].Value = attend_num;

            parameters[2] = new SqlParameter("@attend_deg", SqlDbType.Float);
            parameters[2].Value = attend_deg;

            parameters[3] = new SqlParameter("@abs_numm", SqlDbType.Int);
            parameters[3].Value = abs_numm;

            parameters[4] = new SqlParameter("@abs_deg", SqlDbType.Float);
            parameters[4].Value = abs_deg;

            parameters[5] = new SqlParameter("@subject_deg", SqlDbType.Float);
            parameters[5].Value = subject_deg;

           
            parameters[6] = new SqlParameter("@stu_id", SqlDbType.Int);
            parameters[6].Value = stu_id;

            parameters[7] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[7].Value = sub_id;

            parameters[8] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[8].Value = dept_id;

            parameters[9] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[9].Value = lev_id;

            parameters[10] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[10].Value = sem_id;

            parameters[11] = new SqlParameter("@abs1", SqlDbType.Int);
            parameters[11].Value = abs1;

            parameters[12] = new SqlParameter("@abs2", SqlDbType.Int);
            parameters[12].Value = abs2;

            parameters[13] = new SqlParameter("@abs3", SqlDbType.Int);
            parameters[13].Value = abs3;

            parameters[14] = new SqlParameter("@abs4", SqlDbType.Int);
            parameters[14].Value = abs4;

            parameters[15] = new SqlParameter("@abs5", SqlDbType.Int);
            parameters[15].Value = abs5;

            parameters[16] = new SqlParameter("@abs6", SqlDbType.Int);
            parameters[16].Value = abs6;

            parameters[17] = new SqlParameter("@abs7", SqlDbType.Int);
            parameters[17].Value = abs7;

            parameters[18] = new SqlParameter("@abs8", SqlDbType.Int);
            parameters[18].Value = abs8;

            parameters[19] = new SqlParameter("@abs9", SqlDbType.Int);
            parameters[19].Value = abs9;

            parameters[20] = new SqlParameter("@abs10", SqlDbType.Int);
            parameters[20].Value = abs10;

            parameters[21] = new SqlParameter("@abs11", SqlDbType.Int);
            parameters[21].Value = abs11;

            parameters[22]= new SqlParameter("@abs12", SqlDbType.Int);
            parameters[22].Value = abs12;
            parameters[23] = new SqlParameter("@year_std", SqlDbType.NVarChar,60);
            parameters[23].Value = year_std;



            DAL.ExecuteCommand("add_absance", parameters);
            DAL.Close();
            
        }

        //[UpdateAbsance]
        public void UpdateAbsance(int abs_id,int total_lecnum_subject, int attend_num, float attend_deg, int abs_numm, float abs_deg,
            float subject_deg,
            int stu_id, int sub_id, int dept_id, int lev_id, int sem_id,
            int abs1, int abs2, int abs3, int abs4,
            int abs5, int abs6, int abs7, int abs8,
            int abs9, int abs10, int abs11, int abs12,string year_std)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[25];

            parameters[0] = new SqlParameter("@abs_id", SqlDbType.Int);
            parameters[0].Value = abs_id;

            parameters[1] = new SqlParameter("@total_lecnum_subject", SqlDbType.Int);
            parameters[1].Value = total_lecnum_subject;

            parameters[2] = new SqlParameter("@attend_num", SqlDbType.Int);
            parameters[2].Value = attend_num;

            parameters[3] = new SqlParameter("@attend_deg", SqlDbType.Float);
            parameters[3].Value = attend_deg;

            parameters[4] = new SqlParameter("@abs_numm", SqlDbType.Int);
            parameters[4].Value = abs_numm;

            parameters[5] = new SqlParameter("@abs_deg", SqlDbType.Float);
            parameters[5].Value = abs_deg;

            parameters[6] = new SqlParameter("@subject_deg", SqlDbType.Float);
            parameters[6].Value = subject_deg;

            parameters[7] = new SqlParameter("@stu_id", SqlDbType.Int);
            parameters[7].Value = stu_id;

            parameters[8] = new SqlParameter("@sub_id", SqlDbType.Int);
            parameters[8].Value = sub_id;

            parameters[9] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[9].Value = dept_id;

            parameters[10] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[10].Value = lev_id;

            parameters[11] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[11].Value = sem_id;

            parameters[12] = new SqlParameter("@abs1", SqlDbType.Int);
            parameters[12].Value = abs1;

            parameters[13] = new SqlParameter("@abs2", SqlDbType.Int);
            parameters[13].Value = abs2;

            parameters[14] = new SqlParameter("@abs3", SqlDbType.Int);
            parameters[14].Value = abs3;

            parameters[15] = new SqlParameter("@abs4", SqlDbType.Int);
            parameters[15].Value = abs4;

            parameters[16] = new SqlParameter("@abs5", SqlDbType.Int);
            parameters[16].Value = abs5;

            parameters[17] = new SqlParameter("@abs6", SqlDbType.Int);
            parameters[17].Value = abs6;

            parameters[18] = new SqlParameter("@abs7", SqlDbType.Int);
            parameters[18].Value = abs7;

            parameters[19] = new SqlParameter("@abs8", SqlDbType.Int);
            parameters[19].Value = abs8;

            parameters[20] = new SqlParameter("@abs9", SqlDbType.Int);
            parameters[20].Value = abs9;

            parameters[21] = new SqlParameter("@abs10", SqlDbType.Int);
            parameters[21].Value = abs10;

            parameters[22] = new SqlParameter("@abs11", SqlDbType.Int);
            parameters[22].Value = abs11;

            parameters[23] = new SqlParameter("@abs12", SqlDbType.Int);
            parameters[23].Value = abs12;
            parameters[24] = new SqlParameter("@year_std", SqlDbType.NVarChar, 60);
            parameters[24].Value = year_std;


            DAL.ExecuteCommand("UpdateAbsance", parameters);
            DAL.Close();

        }

        //GetStdFromAbsance
        public int GetStdFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetStdFromAbs", parameters);
            DAL.Close();
            return dt;
        }
        //GetStdNameFromAbsance
        public string GetStdNameFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetStdNameFromAbs", parameters);

            DAL.Close();
            return dt;
        }
        //GetSubjectFromAbs
        public int GetSubjectFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSubjectFromAbs", parameters);
            DAL.Close();
            return dt;
        }

        //GetSemFromAbs
        public int GetSemFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetSemFromAbs", parameters);
            DAL.Close();
            return dt;
        }

        //GetDeptFromAbs
        public int GetDeptFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptFromAbs", parameters);
            DAL.Close();
            return dt;
        }
        


        //GetLevFromAbs
        public int GetLevFromAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetLevFromAbs", parameters);
            DAL.Close();
            return dt;
        }


        //التحقق من وجود درجات للماده
        public DataTable VerifiedAbsSTDId(int dept, int lev, int std, int sub, int sem)
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
            dt = DAL.SelectData("VerifiedAbsSTDId", parameters);
            DAL.Close();
            return dt;
        }

        public void DelAbs(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.ExecuteCommand("DelAbs", parameters);
            DAL.Close();
        }




    }
}
