using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.CRUD.CRUDProducts
{
    public class Creator
    {
        public static void AddOrder(int ProductID, string Productname, int price, string Colour, string Brand, string FrameType, string Glasstype, int RightLensID, int LeftLensID, string Productdescription)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AddProduct";
                com.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                com.Parameters.Add("@Productname", SqlDbType.VarChar).Value = Productname;
                com.Parameters.Add("@Price", SqlDbType.Real).Value = price;
                com.Parameters.Add("@ Colour", SqlDbType.VarChar).Value = Colour;
                com.Parameters.Add("@Brand", SqlDbType.VarChar).Value = Brand;
                com.Parameters.Add("@FrameType", SqlDbType.VarChar).Value = FrameType;
                com.Parameters.Add("@Glasstype", SqlDbType.VarChar).Value = Glasstype;
                com.Parameters.Add("@RightLensID", SqlDbType.Int).Value = RightLensID;
                com.Parameters.Add("@LeftLensID", SqlDbType.Int).Value = LeftLensID;
                com.Parameters.Add("@Productdescription", SqlDbType.VarChar).Value = Productdescription;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();
                com.ExecuteScalar();
                conn.Close();
            }
        }
    }
}
