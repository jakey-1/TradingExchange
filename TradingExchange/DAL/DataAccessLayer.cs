using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TradingExchange.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //inisialize connection
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection("Server=DESKTOP-Q776ERA; Database=TradingExchange; Integrated Security=true");
        }

        //open connection

        public void Open()
        {
            if (sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //close connection

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Read Data From DataBase (select)

        public DataTable SelectData(string stored_procedure, SqlParameter[] param )
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for(int i=0; i<param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Insert Update Delete Data From DataBase

        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;


            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }




    }
}
