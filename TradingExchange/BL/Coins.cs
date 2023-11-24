using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TradingExchange.BL
{
    class Coins
    {
        public DataTable GetConinsInfo()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GetConinsInfo", null);
            DAL.Close();
            return Dt;
        }
    }
}
