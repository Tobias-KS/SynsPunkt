using System.Data;
using System.Data.SqlClient;
namespace Persistence.CRUD
{
    public class Deleter
    {
        //Orders
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

        //Customers
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

        //Products
        public static void DeleteProduct(int ProductID)
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
