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

        //Customer
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

        //Orders
        public static string AlterOrder(int OrderID, int customerID, DateTime Date)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AlterOrder";
                com.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
                com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID;
                com.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();
                com.ExecuteScalar();
                conn.Close();
                return "Order Altered";
            }
        }

        //Products
        public static void AlterProduct(int ProductID, string Productname, float price, string Colour, string Brand, string FrameType, string Glasstype, int? RightLensID, int? LeftLensID, string Productdescription = "")
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AlterProduct";
                com.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                com.Parameters.Add("@Productname", SqlDbType.VarChar).Value = Productname;
                com.Parameters.Add("@Price", SqlDbType.Real).Value = price;
                com.Parameters.Add("@Colour", SqlDbType.VarChar).Value = Colour;
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
