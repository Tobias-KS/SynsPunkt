using System;
using System.Data;
using System.Data.SqlClient;
namespace Persistence.CRUD
{

    public class Creator
    {
        //Customer
        public static string AddCustomer(string Forename, string Lastname, string adress, int PhoneNumber, string Email, double StrengthRight, double StrengthLeft, DateTime SignupDate, string notes = "")
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

        //Product
        public static void AddProduct(string Productname, int Price, string Colour, string Brand, string FrameType, string Glasstype, int RightLensID, int LeftLensID, string Productdescription)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AddProduct";
             //   com.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                com.Parameters.Add("@Productname", SqlDbType.VarChar).Value = Productname;
                com.Parameters.Add("@Price", SqlDbType.Real).Value = Price;
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

        //Order
        public static void AddOrder(int OrderID, int customerID, DateTime Date)
        {
            SqlConnection conn = new SqlConnection(SQLConnecter.Connect());

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = conn;
                com.CommandText = "AddOrder";
                com.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
                com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID;
                com.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
                com.CommandType = CommandType.StoredProcedure;

                conn.Open();
                com.ExecuteScalar();
                conn.Close();
            }
        }

    }
}
