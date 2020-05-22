using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.CRUD.CRUDorder
{
    public class DeleterOrder
    {
        public static void DeleteOrder(int OrderID)
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
            }
        }
     }
}
