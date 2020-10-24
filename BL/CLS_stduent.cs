using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Institute.BL
{
    class CLS_stduent
    {
        //عرض
        public DataTable GetAllStd()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllStd", null);
            DAL.Close();
            return dt;
        }

        public DataTable getstudentFordept_lev_sem(int dept, int lev, int sem)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[0].Value = dept;

            parameters[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[1].Value = lev;

            parameters[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[2].Value = sem;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("getstudentFordept_lev_sem", parameters);
            DAL.Close();
            return dt;
        }
        public DataTable getstudentFordept_lev_sem22(int dept, int lev, int sem)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[0].Value = dept;

            parameters[1] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[1].Value = lev;

            parameters[2] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[2].Value = sem;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("getstudentFordept_lev_sem22", parameters);
            DAL.Close();
            return dt;
        }


        //إضافه طالب جديد"تسجيل الطلاب"
        public void AddStd(string code,
                           string year_study,
                           string year_applay,
                           string stu_name,
                           int birth_day,
                           int birth_month,
                           int birth_year,
                           string birth_place_Governorate,
                           string birth_place_city,
                           string marital_stutus,
                           string gender,
                           string address_Governorate,
                           string address_city,
                           string religion ,
                           string national_id,
                           string phone1,
                           string house_phone1,
                           string email,
                           string address_indetails,
                           int dept_id,
                           string stu_type,
                           string qualification_name,
                           string graduation_year,
                           string graduation_place_name,
                           string gratuation_city,
                           string Guardian_name,
                           string relation,
                           string Guardian_job,
                           string Guardian_nationalid,
                           string Guardian_address,
                           string Guardian_phone1,
                           string Guardian_phone2,
                           byte [] stu_image,
                           string know
                           ,int Lev_id
                           ,int Sem_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[36];

            parameters[0] = new SqlParameter("@code",SqlDbType.VarChar,100);
            parameters[0].Value = code;

            parameters[1] = new SqlParameter("@year_study", SqlDbType.VarChar, 60);
            parameters[1].Value = year_study;

            parameters[2] = new SqlParameter("@year_applay", SqlDbType.VarChar, 100);
            parameters[2].Value = year_applay;

            parameters[3] = new SqlParameter("@stu_name", SqlDbType.VarChar, 200);
            parameters[3].Value = stu_name;

            parameters[4] = new SqlParameter("@birth_day", SqlDbType.Int);
            parameters[4].Value = birth_day;

            parameters[5] = new SqlParameter("@birth_month", SqlDbType.Int);
            parameters[5].Value = birth_month;

            parameters[6] = new SqlParameter("@birth_year", SqlDbType.Int);
            parameters[6].Value = birth_year;

            parameters[7] = new SqlParameter("@birth_place_Governorate", SqlDbType.VarChar,50);
            parameters[7].Value = birth_place_Governorate;

            parameters[8] = new SqlParameter("@birth_place_city", SqlDbType.VarChar, 50);
            parameters[8].Value = birth_place_city;

            parameters[9] = new SqlParameter("@marital_stutus", SqlDbType.VarChar, 20);
            parameters[9].Value = marital_stutus;

            parameters[10] = new SqlParameter("@gender", SqlDbType.VarChar, 20);
            parameters[10].Value = gender;

            parameters[11] = new SqlParameter("@address_Governorate", SqlDbType.VarChar, 50);
            parameters[11].Value = address_Governorate;

            parameters[12] = new SqlParameter("@address_city", SqlDbType.VarChar, 50);
            parameters[12].Value = address_city;

            parameters[13] = new SqlParameter("@religion", SqlDbType.VarChar, 20);
            parameters[13].Value = religion;

            parameters[14] = new SqlParameter("@national_id", SqlDbType.Char,14);
            parameters[14].Value = national_id;

            parameters[15] = new SqlParameter("@phone1", SqlDbType.VarChar,20);
            parameters[15].Value = phone1;


            parameters[16] = new SqlParameter("@house_phone1", SqlDbType.VarChar, 20);
            parameters[16].Value = house_phone1;

            parameters[17] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            parameters[17].Value = email;

            parameters[18] = new SqlParameter("@address_indetails", SqlDbType.VarChar, 200);
            parameters[18].Value = address_indetails;

            parameters[19] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[19].Value = dept_id;

            parameters[20] = new SqlParameter("@stu_type", SqlDbType.VarChar,20);
            parameters[20].Value = stu_type;

            parameters[21] = new SqlParameter("@qualification_name", SqlDbType.VarChar, 200);
            parameters[21].Value = qualification_name;

            parameters[22] = new SqlParameter("@graduation_year", SqlDbType.VarChar,50);
            parameters[22].Value = graduation_year;

            parameters[23] = new SqlParameter("@graduation_place_name", SqlDbType.VarChar,40);
            parameters[23].Value = graduation_place_name;

            parameters[24] = new SqlParameter("@gratuation_city", SqlDbType.VarChar, 20);
            parameters[24].Value = gratuation_city;

            parameters[25] = new SqlParameter("@Guardian_name", SqlDbType.VarChar,100);
            parameters[25].Value = Guardian_name;

            parameters[26] = new SqlParameter("@relation", SqlDbType.VarChar, 20);
            parameters[26].Value = relation;

            parameters[27] = new SqlParameter("@Guardian_job", SqlDbType.VarChar,100);
            parameters[27].Value = Guardian_job;

            parameters[28] = new SqlParameter("@Guardian_nationalid", SqlDbType.VarChar,50);
            parameters[28].Value = Guardian_nationalid;

            parameters[29] = new SqlParameter("@Guardian_address", SqlDbType.VarChar, 100);
            parameters[29].Value = Guardian_address;

            parameters[30] = new SqlParameter("@Guardian_phone1", SqlDbType.VarChar, 20);
            parameters[30].Value = Guardian_phone1;

            parameters[31] = new SqlParameter("@Guardian_phone2", SqlDbType.VarChar, 20);
            parameters[31].Value = Guardian_phone2;

            parameters[32] = new SqlParameter("@stu_image", SqlDbType.Image);
            parameters[32].Value = stu_image;

            parameters[33] = new SqlParameter("@know_place", SqlDbType.VarChar,50);
            parameters[33].Value = know;

            parameters[34] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[34].Value = Lev_id;
            parameters[35] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[35].Value = Sem_id;

            DAL.ExecuteCommand("AddStd", parameters);
            DAL.Close();
        }


        //تعديل بيانات طالب"تعديل بيانات"
        public void UpdateStd(int id,
                           string code,
                           string year_study,
                           string year_applay,
                           string stu_name,
                           int birth_day,
                           int birth_month,
                           int birth_year,
                           string birth_place_Governorate,
                           string birth_place_city,
                           string marital_stutus,
                           string gender,
                           string address_Governorate,
                           string address_city,
                           string religion,
                           string national_id,
                           string phone1,
                           string house_phone1,
                           string email,
                           string address_indetails,
                           int dept_id,
                           string stu_type,
                           string qualification_name,
                           string graduation_year,
                           string graduation_place_name,
                           string gratuation_city,
                           string Guardian_name,
                           string relation,
                           string Guardian_job,
                           string Guardian_nationalid,
                           string Guardian_address,
                           string Guardian_phone1,
                           string Guardian_phone2,
                           byte[] stu_image,
                           string know
                           , int Lev_id
                           , int Sem_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[37];

            parameters[0] = new SqlParameter("@std_id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@code", SqlDbType.VarChar, 100);
            parameters[1].Value = code;

            parameters[2] = new SqlParameter("@year_study", SqlDbType.VarChar, 60);
            parameters[2].Value = year_study;

            parameters[3] = new SqlParameter("@year_applay", SqlDbType.VarChar, 100);
            parameters[3].Value = year_applay;

            parameters[4] = new SqlParameter("@stu_name", SqlDbType.VarChar, 200);
            parameters[4].Value = stu_name;

            parameters[5] = new SqlParameter("@birth_day", SqlDbType.Int);
            parameters[5].Value = birth_day;

            parameters[6] = new SqlParameter("@birth_month", SqlDbType.Int);
            parameters[6].Value = birth_month;

            parameters[7] = new SqlParameter("@birth_year", SqlDbType.Int);
            parameters[7].Value = birth_year;

            parameters[8] = new SqlParameter("@birth_place_Governorate", SqlDbType.VarChar, 50);
            parameters[8].Value = birth_place_Governorate;

            parameters[9] = new SqlParameter("@birth_place_city", SqlDbType.VarChar, 50);
            parameters[9].Value = birth_place_city;

            parameters[10] = new SqlParameter("@marital_stutus", SqlDbType.VarChar, 20);
            parameters[10].Value = marital_stutus;

            parameters[11] = new SqlParameter("@gender", SqlDbType.VarChar, 20);
            parameters[11].Value = gender;

            parameters[12] = new SqlParameter("@address_Governorate", SqlDbType.VarChar, 50);
            parameters[12].Value = address_Governorate;

            parameters[13] = new SqlParameter("@address_city", SqlDbType.VarChar, 50);
            parameters[13].Value = address_city;

            parameters[14] = new SqlParameter("@religion", SqlDbType.VarChar, 20);
            parameters[14].Value = religion;

            parameters[15] = new SqlParameter("@national_id", SqlDbType.Char, 14);
            parameters[15].Value = national_id;

            parameters[16] = new SqlParameter("@phone1", SqlDbType.VarChar, 20);
            parameters[16].Value = phone1;

            parameters[17] = new SqlParameter("@house_phone1", SqlDbType.VarChar, 20);
            parameters[17].Value = house_phone1;

            parameters[18] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            parameters[18].Value = email;

            parameters[19] = new SqlParameter("@address_indetails", SqlDbType.VarChar, 200);
            parameters[19].Value = address_indetails;

            parameters[20] = new SqlParameter("@dept_id", SqlDbType.Int);
            parameters[20].Value = dept_id;

            parameters[21] = new SqlParameter("@stu_type", SqlDbType.VarChar, 20);
            parameters[21].Value = stu_type;

            parameters[22] = new SqlParameter("@qualification_name", SqlDbType.VarChar, 200);
            parameters[22].Value = qualification_name;

            parameters[23] = new SqlParameter("@graduation_year", SqlDbType.VarChar, 50);
            parameters[23].Value = graduation_year;

            parameters[24] = new SqlParameter("@graduation_place_name", SqlDbType.VarChar, 40);
            parameters[24].Value = graduation_place_name;

            parameters[25] = new SqlParameter("@gratuation_city", SqlDbType.VarChar, 20);
            parameters[25].Value = gratuation_city;

            parameters[26] = new SqlParameter("@Guardian_name", SqlDbType.VarChar, 100);
            parameters[26].Value = Guardian_name;

            parameters[27] = new SqlParameter("@relation", SqlDbType.VarChar, 20);
            parameters[27].Value = relation;

            parameters[28] = new SqlParameter("@Guardian_job", SqlDbType.VarChar, 100);
            parameters[28].Value = Guardian_job;

            parameters[29] = new SqlParameter("@Guardian_nationalid", SqlDbType.VarChar, 50);
            parameters[29].Value = Guardian_nationalid;

            parameters[30] = new SqlParameter("@Guardian_address", SqlDbType.VarChar, 100);
            parameters[30].Value = Guardian_address;

            parameters[31] = new SqlParameter("@Guardian_phone1", SqlDbType.VarChar, 20);
            parameters[31].Value = Guardian_phone1;

            parameters[32] = new SqlParameter("@Guardian_phone2", SqlDbType.VarChar, 20);
            parameters[32].Value = Guardian_phone2;

            parameters[33] = new SqlParameter("@stu_image", SqlDbType.Image);
            parameters[33].Value = stu_image;

            parameters[34] = new SqlParameter("@know_place", SqlDbType.VarChar, 50);
            parameters[34].Value = know;

            parameters[35] = new SqlParameter("@lev_id", SqlDbType.Int);
            parameters[35].Value = Lev_id;

            parameters[36] = new SqlParameter("@sem_id", SqlDbType.Int);
            parameters[36].Value = Sem_id;

            DAL.ExecuteCommand("UpdateStd", parameters);
            DAL.Close();
        }

        //التحقق من وجود الطالب
        public DataTable VerifiedStdId(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Id", SqlDbType.Char, 14);
            parameters[0].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifiedStdId", parameters);
            DAL.Close();
            return dt;
        }
        // التحقق من كود الطالب
        public DataTable VerifiedStd_code(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@code", SqlDbType.NVarChar, 100);
            parameters[0].Value =code;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifiedStd_code", parameters);
            DAL.Close();
            return dt;
        }


        //للبحث عن الطالب باسمه
        public DataTable SearchStdName(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar, 200);
            parameters[0].Value = name;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchStdName", parameters);
            DAL.Close();
            return dt;
        }

        //GetYStudyStd
        public string GetYStudyStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetYStudyStd", parameters);
            DAL.Close();
            return dt;
        }


        //GetAdGStd
        public string GetAdGStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetAdGStd", parameters);
            DAL.Close();
            return dt;
        }

        //GetAdCStd
        public string GetAdCStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetAdCStd", parameters);
            DAL.Close();
            return dt;
        }

        //GetAdStStd
        public string GetAdStStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetAdStStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetReligionStd

        public string GetReligionStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetReligionStd", parameters);
            DAL.Close();
            return dt;
        }

        //GetAdDetailStd
        public string GetAdDetailStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetAdDetailStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGuardianNameStd
        public string GetGuardianNameStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianNameStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGuardianRelStd
        public string GetGuardianRelStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianRelStd", parameters);
            DAL.Close();
            return dt;
        }

        //GetGuardianJobStd
        public string GetGuardianJobStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianJobStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGuardianNationIdStd
        public string GetGuardianNationIdStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianNationIdStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGuardianPhone1Std
        public string GetGuardianPhone1Std(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianPhone1Std", parameters);
            DAL.Close();
            return dt;
        }
        //GetGuardianPhone2Std
        public string GetGuardianPhone2Std(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianPhone2Std", parameters);
            DAL.Close();
            return dt;
        }

        //GetGuardianAdStd
        public string GetGuardianAdStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGuardianAdStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetYearGradStd
        public string GetYearGradStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetYearGradStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGradPlaceStd
        public string GetGradPlaceStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGradPlaceStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetGradCStd
        public string GetGradCStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetGradCStd", parameters);
            DAL.Close();
            return dt;
        }
        //GetknownStd
        public string GetknownStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("GetknownStd", parameters);
            DAL.Close();
            return dt;
        }

        public string getgrade(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            string dt;
            dt = DAL.SelectDataString("getgrade", parameters);
            DAL.Close();
            return dt;
        }


        //لعرض صوره الطالب 
        public DataTable GetImgStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetImgStd", parameters);
            DAL.Close();
            return dt;
        }
        public string GetStuType(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            string dt;
            dt = DAL.SelectDataString("GetStuType", parameters);
            DAL.Close();
            return dt;
        }


        //حذف الطالب
        public void DelStd(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.ExecuteCommand("DelStd", parameters);
            DAL.Close();
        }



        public int GetDeptFromgraduate(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptFromgraduate", parameters);
            DAL.Close();
            return dt;
        }

    }
}
