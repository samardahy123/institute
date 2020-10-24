using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute.BL
{
    public class CLS_Account
    {

        //GetAccount
        public DataTable GetAccount()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAccount", null);
            DAL.Close();
            return dt;
        }
        

        public DataTable Add_Account(string acc_date1 ,string code1 , float price1,
                                     string acc_date2, string code2, float price2,
                                     string acc_dat3, string code3, float price3,
                                     string acc_date4, string code4, float price4,
                                     string acc_date5, string code5, float price5,
                                     string acc_date6, string code6, float price6,
                                     string m1, float rest1,
                                     string acc_date7, string code7, float price7,
                                     string acc_date8, string code8, float price8,
                                     string m2, float rest2,
                                     string acc_date9, string code9, float price9,
                                     string acc_date10, string code10, float price10,
                                     string m3,float rest3,
                                    string acc_date11 ,string code11,float price11 ,
                                    string acc_date12 ,string code12 ,
                                    float price12 , string m4 , 
             float total ,int stu_id, int lev_id, int dept_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[47];

            param[0] = new SqlParameter("@acc_date1", SqlDbType.Date);
            param[0].Value = acc_date1;
            param[1] = new SqlParameter("@code1", SqlDbType.VarChar, 50);
            param[1].Value = code1;
            param[2] = new SqlParameter("@price1", SqlDbType.Float);
            param[2].Value = price1;

            param[3] = new SqlParameter("@acc_date2", SqlDbType.Date);
            param[3].Value = acc_date2;
            param[4] = new SqlParameter("@code2", SqlDbType.VarChar, 50);
            param[4].Value = code2;
            param[5] = new SqlParameter("@price2", SqlDbType.Float);
            param[5].Value = price2;

            param[6] = new SqlParameter("@acc_dat3", SqlDbType.Date);
            param[6].Value = acc_dat3;
            param[7] = new SqlParameter("@code3", SqlDbType.VarChar, 50);
            param[7].Value = code3;
            param[8] = new SqlParameter("@price3", SqlDbType.Float);
            param[8].Value = price3;

            param[9] = new SqlParameter("@acc_date4", SqlDbType.Date);
            param[9].Value = acc_date4;
            param[10] = new SqlParameter("@code4", SqlDbType.VarChar, 50);
            param[10].Value = code4;
            param[11] = new SqlParameter("@price4", SqlDbType.Float);
            param[11].Value = price4;

            param[12] = new SqlParameter("@acc_date5", SqlDbType.Date);
            param[12].Value = acc_date5;
            param[13] = new SqlParameter("@code5", SqlDbType.VarChar, 50);
            param[13].Value = code5;
            param[14] = new SqlParameter("@price5", SqlDbType.Float);
            param[14].Value = price5;

            param[15] = new SqlParameter("@acc_date6", SqlDbType.Date);
            param[15].Value = acc_date6;
            param[16] = new SqlParameter("@code6", SqlDbType.VarChar, 50);
            param[16].Value = code6;
            param[17] = new SqlParameter("@price6", SqlDbType.Float);
            param[17].Value = price6;

            param[18] = new SqlParameter("@m1", SqlDbType.VarChar, 200);
            param[18].Value = m1;

            param[19] = new SqlParameter("@rest1", SqlDbType.Float);
            param[19].Value = rest1;


            param[20] = new SqlParameter("@acc_date7", SqlDbType.Date);
            param[20].Value = acc_date7;
            param[21] = new SqlParameter("@code7", SqlDbType.VarChar, 50);
            param[21].Value = code7;
            param[22] = new SqlParameter("@price7", SqlDbType.Float);
            param[22].Value = price7;

            param[23] = new SqlParameter("@acc_date8", SqlDbType.Date);
            param[23].Value = acc_date8;
            param[24] = new SqlParameter("@code8", SqlDbType.VarChar, 50);
            param[24].Value = code8;
            param[25] = new SqlParameter("@price8", SqlDbType.Float);
            param[25].Value = price8;

            param[26] = new SqlParameter("@m2", SqlDbType.VarChar, 200);
            param[26].Value = m2;

            param[27] = new SqlParameter("@rest2", SqlDbType.Float);
            param[27].Value = rest2;
            
            param[28] = new SqlParameter("@acc_date9", SqlDbType.Date);
            param[28].Value = acc_date9;
            param[29] = new SqlParameter("@code9", SqlDbType.VarChar, 50);
            param[29].Value = code9;
            param[30] = new SqlParameter("@price9", SqlDbType.Float);
            param[30].Value = price9;

            param[31] = new SqlParameter("@acc_date10", SqlDbType.Date);
            param[31].Value = acc_date10;
            param[32] = new SqlParameter("@code10", SqlDbType.VarChar, 50);
            param[32].Value = code10;
            param[33] = new SqlParameter("@price10", SqlDbType.Float);
            param[33].Value = price10;

            param[34] = new SqlParameter("@m3", SqlDbType.VarChar, 200);
            param[34].Value = m3;

            param[35] = new SqlParameter("@rest3", SqlDbType.Float);
            param[35].Value = rest3;

            param[36] = new SqlParameter("@acc_date11", SqlDbType.Date);
            param[36].Value = acc_date11;
            param[37] = new SqlParameter("@code11", SqlDbType.VarChar, 50);
            param[37].Value = code11;
            param[38] = new SqlParameter("@price11", SqlDbType.Float);
            param[38].Value = price11;

            param[39] = new SqlParameter("@acc_date12", SqlDbType.Date);
            param[39].Value = acc_date12;
            param[40] = new SqlParameter("@code12", SqlDbType.VarChar, 50);
            param[40].Value = code12;
            param[41] = new SqlParameter("@price12", SqlDbType.Float);
            param[41].Value = price12;

            param[42] = new SqlParameter("@m4", SqlDbType.VarChar, 200);
            param[42].Value = m4;

            param[43] = new SqlParameter("@total", SqlDbType.Float);
            param[43].Value = total;
            param[44] = new SqlParameter("@stu_id", SqlDbType.Int);
            param[44].Value = stu_id;
            param[45] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[45].Value = lev_id;
            param[46] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[46].Value = dept_id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Add_Account", param);
            DAL.Close();
            return dt;
        }



        public DataTable UpdateAccount (int account_id,
                                         string acc_date1, string code1, float price1,
                                         string acc_date2, string code2, float price2,
                                         string acc_dat3, string code3, float price3,
                                         string acc_date4, string code4, float price4,
                                         string acc_date5, string code5, float price5,
                                         string acc_date6, string code6, float price6,
                                         string m1, float rest1,
                                         string acc_date7, string code7, float price7,
                                         string acc_date8, string code8, float price8,
                                         string m2, float rest2,
                                         string acc_date9, string code9, float price9,
                                         string acc_date10, string code10, float price10,
                                         string m3, float rest3,
                                         string acc_date11, string code11, float price11,
                                    string acc_date12, string code12,
                                    float price12, string m4,float total)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[45];

            param[0] = new SqlParameter("@account_id", SqlDbType.Int);
            param[0].Value = account_id;

            param[1] = new SqlParameter("@acc_date1", SqlDbType.Date);
            param[1].Value = acc_date1;
            param[2] = new SqlParameter("@code1", SqlDbType.VarChar, 50);
            param[2].Value = code1;
            param[3] = new SqlParameter("@price1", SqlDbType.Float);
            param[3].Value = price1;

            param[4] = new SqlParameter("@acc_date2", SqlDbType.Date);
            param[4].Value = acc_date2;
            param[5] = new SqlParameter("@code2", SqlDbType.VarChar, 50);
            param[5].Value = code2;
            param[6] = new SqlParameter("@price2", SqlDbType.Float);
            param[6].Value = price2;

            param[7] = new SqlParameter("@acc_dat3", SqlDbType.Date);
            param[7].Value = acc_dat3;
            param[8] = new SqlParameter("@code3", SqlDbType.VarChar, 50);
            param[8].Value = code3;
            param[9] = new SqlParameter("@price3", SqlDbType.Float);
            param[9].Value = price3;

            param[10] = new SqlParameter("@acc_date4", SqlDbType.Date);
            param[10].Value = acc_date4;
            param[11] = new SqlParameter("@code4", SqlDbType.VarChar, 50);
            param[11].Value = code4;
            param[12] = new SqlParameter("@price4", SqlDbType.Float);
            param[12].Value = price4;

            param[13] = new SqlParameter("@acc_date5", SqlDbType.Date);
            param[13].Value = acc_date5;
            param[14] = new SqlParameter("@code5", SqlDbType.VarChar, 50);
            param[14].Value = code5;
            param[15] = new SqlParameter("@price5", SqlDbType.Float);
            param[15].Value = price5;

            param[16] = new SqlParameter("@acc_date6", SqlDbType.Date);
            param[16].Value = acc_date6;
            param[17] = new SqlParameter("@code6", SqlDbType.VarChar, 50);
            param[17].Value = code6;
            param[18] = new SqlParameter("@price6", SqlDbType.Float);
            param[18].Value = price6;

            param[19] = new SqlParameter("@m1", SqlDbType.VarChar, 200);
            param[19].Value = m1;

            param[20] = new SqlParameter("@rest1", SqlDbType.Float);
            param[20].Value = rest1;


            param[21] = new SqlParameter("@acc_date7", SqlDbType.Date);
            param[21].Value = acc_date7;
            param[22] = new SqlParameter("@code7", SqlDbType.VarChar, 50);
            param[22].Value = code7;
            param[23] = new SqlParameter("@price7", SqlDbType.Float);
            param[23].Value = price7;

            param[24] = new SqlParameter("@acc_date8", SqlDbType.Date);
            param[24].Value = acc_date8;
            param[25] = new SqlParameter("@code8", SqlDbType.VarChar, 50);
            param[25].Value = code8;
            param[26] = new SqlParameter("@price8", SqlDbType.Float);
            param[26].Value = price8;

            param[27] = new SqlParameter("@m2", SqlDbType.VarChar, 200);
            param[27].Value = m2;

            param[28] = new SqlParameter("@rest2", SqlDbType.Float);
            param[28].Value = rest2;

            param[29] = new SqlParameter("@acc_date9", SqlDbType.Date);
            param[29].Value = acc_date9;
            param[30] = new SqlParameter("@code9", SqlDbType.VarChar, 50);
            param[30].Value = code9;
            param[31] = new SqlParameter("@price9", SqlDbType.Float);
            param[31].Value = price9;

            param[32] = new SqlParameter("@acc_date10", SqlDbType.Date);
            param[32].Value = acc_date10;
            param[33] = new SqlParameter("@code10", SqlDbType.VarChar, 50);
            param[33].Value = code10;
            param[34] = new SqlParameter("@price10", SqlDbType.Float);
            param[34].Value = price10;

            param[35] = new SqlParameter("@m3", SqlDbType.VarChar, 200);
            param[35].Value = m3;

            param[36] = new SqlParameter("@rest3", SqlDbType.Float);
            param[36].Value = rest3;

            param[37] = new SqlParameter("@acc_date11", SqlDbType.Date);
            param[37].Value = acc_date11;
            param[38] = new SqlParameter("@code11", SqlDbType.VarChar, 50);
            param[38].Value = code11;
            param[39] = new SqlParameter("@price11", SqlDbType.Float);
            param[39].Value = price11;

            param[40] = new SqlParameter("@acc_date12", SqlDbType.Date);
            param[40].Value = acc_date12;
            param[41] = new SqlParameter("@code12", SqlDbType.VarChar, 50);
            param[41].Value = code12;
            param[42] = new SqlParameter("@price12", SqlDbType.Float);
            param[42].Value = price12;

            param[43] = new SqlParameter("@m4", SqlDbType.VarChar, 200);
            param[43].Value = m4;

            param[44] = new SqlParameter("@total", SqlDbType.Float);
            param[44].Value = total;
            

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateAccount", param);
            DAL.Close();
            return dt;
        }
        
        public DataTable AddFee1(string acc1, string code1,float price1,
                                string acc2, string code2, float price2,
                                string m,float r, int std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@acc_date5", SqlDbType.Date);
            param[0].Value = acc1;

            param[1] = new SqlParameter("@code5", SqlDbType.VarChar,50);
            param[1].Value = code1;

            param[2] = new SqlParameter("@price5", SqlDbType.Float);
            param[2].Value = price1;


            param[3] = new SqlParameter("@acc_date6", SqlDbType.Date);
            param[3].Value = acc2;

            param[4] = new SqlParameter("@code6", SqlDbType.VarChar,50);
            param[4].Value = code2;

            param[5] = new SqlParameter("@price6", SqlDbType.Float);
            param[5].Value = price2;

            param[6] = new SqlParameter("@m1", SqlDbType.VarChar, 200);
            param[6].Value = m;

            param[7] = new SqlParameter("@rest1", SqlDbType.Float);
            param[7].Value = r;

            param[8] = new SqlParameter("@std_id", SqlDbType.Int);
            param[8].Value = std;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("AddFee1", param);
            DAL.Close();
            return dt;
        }


        public DataTable AddFee2(string acc1, string code1, float price1,
                                string acc2, string code2, float price2,
                                string m, float r, int std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@acc_date7", SqlDbType.Date);
            param[0].Value = acc1;

            param[1] = new SqlParameter("@code7", SqlDbType.VarChar, 50);
            param[1].Value = code1;

            param[2] = new SqlParameter("@price7", SqlDbType.Float);
            param[2].Value = price1;


            param[3] = new SqlParameter("@acc_date8", SqlDbType.Date);
            param[3].Value = acc2;

            param[4] = new SqlParameter("@code8", SqlDbType.VarChar, 50);
            param[4].Value = code2;

            param[5] = new SqlParameter("@price8", SqlDbType.Float);
            param[5].Value = price2;

            param[6] = new SqlParameter("@m2", SqlDbType.VarChar,200);
            param[6].Value = m;

            param[7] = new SqlParameter("@rest2", SqlDbType.Float);
            param[7].Value = r;

            param[8] = new SqlParameter("@std_id", SqlDbType.Int);
            param[8].Value = std;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("AddFee2", param);
            DAL.Close();
            return dt;
        }

        public DataTable AddFee3(string acc1, string code1, float price1,
                        string acc2, string code2, float price2,
                        string m, float r, int std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@acc_date9", SqlDbType.Date);
            param[0].Value = acc1;

            param[1] = new SqlParameter("@code9", SqlDbType.VarChar, 50);
            param[1].Value = code1;

            param[2] = new SqlParameter("@price9", SqlDbType.Float);
            param[2].Value = price1;


            param[3] = new SqlParameter("@acc_date10", SqlDbType.Date);
            param[3].Value = acc2;

            param[4] = new SqlParameter("@code10", SqlDbType.VarChar, 50);
            param[4].Value = code2;

            param[5] = new SqlParameter("@price10", SqlDbType.Float);
            param[5].Value = price2;

            param[6] = new SqlParameter("@m3", SqlDbType.VarChar,100);
            param[6].Value = m;

            param[7] = new SqlParameter("@total", SqlDbType.Float);
            param[7].Value = r;

            param[8] = new SqlParameter("@std_id", SqlDbType.Int);
            param[8].Value = std;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("AddFee3", param);
            DAL.Close();
            return dt;
        }


        public DataTable GetFees()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetFees", null);
            DAL.Close();
            return dt;
        }

        //للبحث عن الطالب باسمه
        public DataTable SearchStdNameAccount(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@name", SqlDbType.VarChar, 200);
            parameters[0].Value = name;


            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchStdNameAccount", parameters);
            DAL.Close();
            return dt;
        }
        
        
        //GetStdFromAccount

        public String GetStdFromAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            String dt;
            dt = DAL.SelectDataString("GetStdFromAccount", parameters);
            DAL.Close();
            return dt;
        }
        //GetLevFromAccount
        public String GetLevFromAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            String dt;
            dt = DAL.SelectDataString("GetLevFromAccount",parameters);
            DAL.Close();
            return dt;
        }

        //GetDeptFromAccount
        public String GetDeptFromAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            String dt;
            dt = DAL.SelectDataString("GetDeptFromAccount", parameters);
            DAL.Close();
            return dt;
        }

        //GetDeptIDFromAccount
        public int GetDeptIdFromAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetDeptIdFromAccount", parameters);
            DAL.Close();
            return dt;
        }
        //GetSemFromAccount
        public String GetSemFromAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            String dt;
            dt = DAL.SelectDataString("GetSemFromAccount", parameters);
            DAL.Close();
            return dt;
        }
        public String get_code1from_account(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@code", SqlDbType.NVarChar,100);
            parameters[0].Value =code;

            String dt;
            dt = DAL.SelectDataString("get_code1from_account", parameters);
            DAL.Close();
            return dt;
        }
        public String get_code2from_account(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@code", SqlDbType.NVarChar, 100);
            parameters[0].Value = code;

            String dt;
            dt = DAL.SelectDataString("get_code2from_account", parameters);
            DAL.Close();
            return dt;
        }
        public String get_code3from_account(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@code", SqlDbType.NVarChar, 100);
            parameters[0].Value = code;

            String dt;
            dt = DAL.SelectDataString("get_code3from_account", parameters);
            DAL.Close();
            return dt;
        }

        public String get_code4from_account(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@code", SqlDbType.NVarChar, 100);
            parameters[0].Value = code;

            String dt;
            dt = DAL.SelectDataString("get_code4from_account", parameters);
            DAL.Close();
            return dt;
        }



        //التحقق من وجود الحساب
        public DataTable VerifiedAccountId(int dept,int lev,int std)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@dept", SqlDbType.Int);
            parameters[0].Value = dept;


            parameters[1] = new SqlParameter("@lev", SqlDbType.Int);
            parameters[1].Value = lev;

            parameters[2] = new SqlParameter("@std", SqlDbType.Int);
            parameters[2].Value = std;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifiedAccountId", parameters);
            DAL.Close();
            return dt;
        }


        public void DelAccount(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            DAL.ExecuteCommand("DelAccount", parameters);
            DAL.Close();
        }




    }
}
