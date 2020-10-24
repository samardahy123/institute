using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute.BL
{
    class CLS_department
    {
        public DataTable all_department1()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("all_department1", null);
            DAL.Close();
            return dt;
        }

        public DataTable all_department()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("all_department", null);
            DAL.Close();
            return dt;
        }

        public int GetTotalPriceDept(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetTotalPriceDept", parameters);
            DAL.Close();
            return dt;
        }

        public int GetPrice1Dept(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetPrice1Dept", parameters);
            DAL.Close();
            return dt;
        }

        public int GetPrice2Dept(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetPrice2Dept", parameters);
            DAL.Close();
            return dt;
        }

        public int GetPrice3Dept(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetPrice3Dept", parameters);
            DAL.Close();
            return dt;
        }
        public int GetPrice4Dept(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            int dt;
            dt = DAL.SelectDataInt("GetPrice4Dept", parameters);
            DAL.Close();
            return dt;
        }
        public int GetDeptId(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            parameters[0].Value = name;
            int dt;
            dt = DAL.SelectDataInt("GetDeptIdFromDeptName", parameters);
            DAL.Close();
            return dt;
        }

        public DataTable add_department(string dept_name, int total_price, int price1, string date1, int price2, string date2, int price3, string date3, int price4, string date4)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@dept_name", SqlDbType.NVarChar, 200);
            param[0].Value = dept_name;

            param[1] = new SqlParameter("@total_price", SqlDbType.Int);
            param[1].Value = total_price;

            param[2] = new SqlParameter("@price1", SqlDbType.Int);
            param[2].Value = price1;

            param[3] = new SqlParameter("@date1", SqlDbType.Date);
            param[3].Value = date1;

            param[4] = new SqlParameter("@price2", SqlDbType.Int);
            param[4].Value = price2;

            param[5] = new SqlParameter("@date2", SqlDbType.Date);
            param[5].Value = date2;

            param[6] = new SqlParameter("@price3", SqlDbType.Int);
            param[6].Value = price3;

            param[7] = new SqlParameter("@date3", SqlDbType.Date);
            param[7].Value = date3;

            param[8] = new SqlParameter("@price4", SqlDbType.Int);
            param[8].Value = price4;

            param[9] = new SqlParameter("@date4", SqlDbType.Date);
            param[9].Value = date4;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("add_department", param);
            DAL.Close();
            return dt;
        }

        public DataTable UpdateDept(int id, string dept_name, int total_price, int price1, string date1, int price2, string date2, int price3, string date3, int price4, string date4)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@dept_id", SqlDbType.NVarChar, 200);
            param[0].Value = id;

            param[1] = new SqlParameter("@dept_name", SqlDbType.NVarChar, 200);
            param[1].Value = dept_name;

            param[2] = new SqlParameter("@total_price", SqlDbType.Int);
            param[2].Value = total_price;

            param[3] = new SqlParameter("@price1", SqlDbType.Int);
            param[3].Value = price1;

            param[4] = new SqlParameter("@date1", SqlDbType.Date);
            param[4].Value = date1;

            param[5] = new SqlParameter("@price2", SqlDbType.Int);
            param[5].Value = price2;

            param[6] = new SqlParameter("@date2", SqlDbType.Date);
            param[6].Value = date2;

            param[7] = new SqlParameter("@price3", SqlDbType.Int);
            param[7].Value = price3;

            param[8] = new SqlParameter("@date3", SqlDbType.Date);
            param[8].Value = date3; DAL.Open();

            param[9] = new SqlParameter("@price4", SqlDbType.Int);
            param[9].Value = price4;

            param[10] = new SqlParameter("@date4", SqlDbType.Date);
            param[10].Value = date4;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("UpdateDept", param);
            DAL.Close();
            return dt;
        }



        public DataTable delet_department(string dept_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dept_id", SqlDbType.Int);
            param[0].Value = dept_id;

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("delete_department", param);
            DAL.Close();
            return dt;
        }
        public DataTable search_department(String criteration)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@criteration ", SqlDbType.NVarChar, 50);
            param[0].Value = criteration;

            dt = DAL.SelectData("search_department", param);
            DAL.Close();
            return dt;
        }

    }

}

