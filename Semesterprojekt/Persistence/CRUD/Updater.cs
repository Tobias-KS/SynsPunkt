using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading;
using Persistence.Models;

namespace Persistence.CRUD
{
    public class Updater
    {
        public static string AlterCustomer(string forename, string lastname, string adress, int phoneNumber, string email, float strengthRight, float strengthLeft, string notes, DateTime signupDate, int CustomerID)
        {
            
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AlterCustomer";
                com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                com.Parameters.Add("@Forename", SqlDbType.VarChar).Value = forename;
                com.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = lastname;
                com.Parameters.Add("@adress", SqlDbType.VarChar).Value = adress;
                com.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = phoneNumber;
                com.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                com.Parameters.Add("@StrengthRight", SqlDbType.Float).Value = strengthRight;
                com.Parameters.Add("@StrengthLeft", SqlDbType.Float).Value = strengthLeft;
                com.Parameters.Add("@notes", SqlDbType.VarChar).Value = notes;
                com.Parameters.Add("@SignupDate", SqlDbType.Date).Value = signupDate;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();

                com.ExecuteScalar();

                conn.Close();

                return "Customer Created!";

            }

        }
    }
}
