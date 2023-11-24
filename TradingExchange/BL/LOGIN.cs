using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingExchange.BL
{
    class LOGIN
    {
        public DataTable USERLOGIN(string Email, string Password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            param[0].Value = Email;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            param[1].Value = Password;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Close();
            return Dt;
        }
    }
}
