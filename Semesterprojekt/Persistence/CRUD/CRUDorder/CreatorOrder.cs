using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.CRUD.CRUDorder
{
    public class CreatorOrder
    {
        public static string AddOrder(int OrderID, int customerID, DateTime Date)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection=conn;
                com.CommandText = "AddOrder";
                com.Parameters.Add ("@OrderID", SqlDbType.Int).Value = OrderID;
                com.Parameters.Add ("@CustomerID", SqlDbType.Int).Value = customerID;
                com.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();
                com.ExecuteScalar();
                conn.Close();
                return "Order Created";

            }    
        }
    }
}
