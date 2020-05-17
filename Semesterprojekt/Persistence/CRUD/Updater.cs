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
        public static string AlterCustomer(string Forename, string Lastname, string adress, int PhoneNumber, string Email, int StrengthRight, int StrengthLeft, string notes, DateTime SignupDate, int CustomerID)
        {
            
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AlterCustomer";
                com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                com.Parameters.Add("@Forename", SqlDbType.VarChar).Value = Forename;
                com.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = Lastname;
                com.Parameters.Add("@adress", SqlDbType.VarChar).Value = adress;
                com.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = PhoneNumber;
                com.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                com.Parameters.Add("@StrengthRight", SqlDbType.Int).Value = StrengthRight;
                com.Parameters.Add("@StrengthLeft", SqlDbType.Int).Value = StrengthLeft;
                com.Parameters.Add("@notes", SqlDbType.VarChar).Value = notes;
                com.Parameters.Add("@SignupDate", SqlDbType.Date).Value = SignupDate;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();

                com.ExecuteScalar();

                conn.Close();

                return "Customer Created!";

            }

        }
    }
}
