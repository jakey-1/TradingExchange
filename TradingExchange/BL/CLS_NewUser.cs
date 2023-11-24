using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TradingExchange.BL
{
    class CLS_NewUser
    {
        public void AddNewUser(string First_Name, string Last_Name, string User_Name,
            string Email, string Password, string Date_Birth, string Regester_Date, string Country, string City, byte[] KYC_DOC)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@First_Name", SqlDbType.NVarChar,50);
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.NVarChar,50);
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@User_Name", SqlDbType.NVarChar,50);
            param[2].Value = User_Name;

            param[3] = new SqlParameter("@Email", SqlDbType.NVarChar,50);
            param[3].Value = Email;

            param[4] = new SqlParameter("@Password", SqlDbType.NVarChar,50);
            param[4].Value = Password;

            param[5] = new SqlParameter("@Date_Birth", SqlDbType.Date);
            param[5].Value = Date_Birth;

            param[6] = new SqlParameter("@Regester_Date", SqlDbType.Date);
            param[6].Value = Regester_Date;

            param[7] = new SqlParameter("@Country", SqlDbType.NVarChar,50);
            param[7].Value = Country;

            param[8] = new SqlParameter("@City", SqlDbType.NVarChar,50);
            param[8].Value = City;

            param[9] = new SqlParameter("@KYC_DOC", SqlDbType.Image);
            param[9].Value = KYC_DOC;

            DAL.ExecuteCommand("add_NewUser", param);
            DAL.Close();




        }


        


    }
}
