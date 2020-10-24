using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Institute.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        // this instructor to initialize connection object
        public DataAccessLayer() {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL") {
                
                

                sqlconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; " +
                    "DataBase = " + Properties.Settings.Default.Database + "; " +
                    "Integrated Security = false; User ID="+ Properties.Settings.Default.ID + ";Password="+ Properties.Settings.Default.Password+"");


            }
            else {
                sqlconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; DataBase = " + Properties.Settings.Default.Database + "; Integrated Security = true");
        } }
       
        //method to open the connection 
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //method to close  the connection 
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //method to read data from database
        public DataTable SelectData(String storedProcedure, SqlParameter[] param)
        {
          
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataAdapter SelectDataGetAdpat(String storedProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            return da;
        }

        public int SelectDataInt(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            Open();
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            int id = Convert.ToInt16(sqlCommand.ExecuteScalar());
            Close();
            return id;
        }

        public String SelectDataString(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }

            return sqlCommand.ExecuteScalar().ToString();
        }



        //methods to insert,update and delete data from database
        public void ExecuteCommand(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
           sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            Open();
            sqlCommand.ExecuteNonQuery();
            Close();
        }
    }
}

