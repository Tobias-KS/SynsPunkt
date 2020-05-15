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
    public class Reader
    {
        public static DataTable GetCustomersDataTable() 
        {
            var customersDataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(SQLConnecter.Connect()))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    com.CommandText = "SelectAllCustomers";
                    com.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = com.ExecuteReader();

                    customersDataTable.Load(reader);
                    customersDataTable.Columns.Remove("Notes");
                    //customersDataTable.Columns.Remove("Email");
                    customersDataTable.Columns["CustomerID"].ColumnName = "ID";
                    customersDataTable.Columns["StrengthRight"].ColumnName = "SR";
                    customersDataTable.Columns["StrengthLeft"].ColumnName = "SL";

                }
            }

            return customersDataTable;
        }


        /*
        public static List<Customer> SelectAllCustomers()
        {
            var conn = new SqlConnection(SQLConnecter.Connect());
            conn.Open();
            var com = new SqlCommand
            {
                Connection = conn,
                CommandText = "SelectAllCustomers",
                CommandType = CommandType.StoredProcedure
            };
            List<Customer> tempCustomerList = new List<Customer>();
            SqlDataReader readCustomers = com.ExecuteReader();
            while (readCustomers.Read())
            {
               
                var tempCustomer = new Customer
                {
                    CustomerID = Convert.ToInt32(readCustomers[0]),
                    Forename = readCustomers[1].ToString(),
                    Lastname = readCustomers[2].ToString(),
                    Adress = readCustomers[3].ToString(),
                    PhoneNumber = Convert.ToInt32(readCustomers[4]),
                    Email = readCustomers[5].ToString(),
                    StrengthRight = Convert.ToDouble(readCustomers[6]),
                    StrengthLeft = Convert.ToDouble(readCustomers[7]),
                    Notes = readCustomers[8].ToString(),
                    SignupDate = Convert.ToDateTime(readCustomers[9])
                };
                tempCustomerList.Add(tempCustomer);

            }

            conn.Close();



            return tempCustomerList;
        }
        public static Customer SelectCustomer()
        {
            int CustomerID = int.Parse(Console.ReadLine());
            var conn = new SqlConnection(SQLConnecter.Connect());
            conn.Open();
            var com = new SqlCommand
            {
                Connection = conn,
                CommandText = "SelectCustomer",
                CommandType = CommandType.StoredProcedure
            };
            var tempCustomer = new Customer();
            com.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int)).Value = CustomerID;
            SqlDataReader readCustomers = com.ExecuteReader();
            while (readCustomers.Read())
            {
                tempCustomer.CustomerID = Convert.ToInt32(readCustomers[0]);
                    tempCustomer.Forename = readCustomers[1].ToString();
                    tempCustomer.Lastname = readCustomers[2].ToString();
                    tempCustomer.Adress = readCustomers[3].ToString();
                    tempCustomer.PhoneNumber = Convert.ToInt32(readCustomers[4]);
                    tempCustomer.Email = readCustomers[5].ToString();
                    tempCustomer.StrengthRight = Convert.ToDouble(readCustomers[6]);
                    tempCustomer.StrengthLeft = Convert.ToDouble(readCustomers[7]);
                    tempCustomer.Notes = readCustomers[8].ToString();
                    tempCustomer.SignupDate = Convert.ToDateTime(readCustomers[9]);
            }
            conn.Close();
            return tempCustomer;


        }
        //com.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int)).Value = customer.customerID;

    */
    }
}