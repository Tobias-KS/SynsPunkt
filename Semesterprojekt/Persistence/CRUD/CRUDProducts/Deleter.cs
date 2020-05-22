using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.CRUD.CRUDProducts
{
    public class Deleter
    {
        public static void DeleteProduct (int ProductID)
        {


            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());
            using (SqlCommand com = new SqlCommand()) 
            {
                com.Connection = conn;
                com.CommandText = "DeleteProduct";
                com.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();
                com.ExecuteScalar();
                conn.Close();
            }
        }   
    }
}
