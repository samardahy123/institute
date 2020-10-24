using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute.BL
{
    class CLS_lev_sem
    {
        public DataTable getallsemfor_lev(int lev_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lev_id", SqlDbType.Int);
            param[0].Value = lev_id;

            dt = DAL.SelectData("getallsemfor_lev", param);
            DAL.Close();
            return dt;
        }

        public DataTable all_lev()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("all_lev", null);
            DAL.Close();
            return dt;
        }

        public int GetLevId(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            parameters[0].Value = name;
            int dt;
            dt = DAL.SelectDataInt("GetLevIdFromLevName", parameters);
            DAL.Close();
            return dt;
        }

        public int GetSemId(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            parameters[0].Value = name;
            int dt;
            dt = DAL.SelectDataInt("GetSemIdFromSemName", parameters);
            DAL.Close();
            return dt;
        }
    }
}
