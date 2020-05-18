﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Persistence.Models;
using System.Data.SqlClient;
namespace Persistence.CRUD
{

    public class Creator
    {
        
        public static string CreateCustomer(string Forename, string Lastname, string adress, int PhoneNumber, string Email, float StrengthRight, float StrengthLeft, DateTime SignupDate, string notes = "")
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AddCustomer";
                com.Parameters.Add("@Forename", SqlDbType.VarChar).Value = Forename;
                com.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = Lastname;
                com.Parameters.Add("@adress", SqlDbType.VarChar).Value = adress;
                com.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = PhoneNumber;
                com.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;
                com.Parameters.Add("@StrengthRight", SqlDbType.Float).Value = StrengthRight;
                com.Parameters.Add("@StrengthLeft", SqlDbType.Float).Value = StrengthLeft;
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