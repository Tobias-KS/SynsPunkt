using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Persistence.Models;
using System.Data.SqlClient;
namespace Persistence.CRUD
{
    public class Deleter
    {
        public class DeleterOrder
        {
            public static string DeleteOrder(int OrderID)
            {
                SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    com.CommandText = "DeleteOrder";
                    com.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
                    com.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    com.ExecuteScalar();
                    conn.Close();
                    return "Order Deleted";
                }
            }
        }
        public static string DeleteCustomer(int CustomerID)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "DeleteCustomer";
                com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                com.CommandType = CommandType.StoredProcedure;
                
                conn.Open();

                com.ExecuteScalar();

                conn.Close();
                return "Customer deleted!";

            }
        }
    }
}
