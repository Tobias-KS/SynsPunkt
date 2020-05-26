using System;
using System.Data;
using System.Data.SqlClient;

namespace Persistence.CRUD
{
    public class Reader
    {
        //Orders
        public static DataTable LoadOrderTable()
        {
            var OrderTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(SQLConnecter.Connect()))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    com.CommandText = "SelectAllOrders";
                    com.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    OrderTable.Load(reader);
                }
            }
            return OrderTable;
        }

        private static DataTable FormatOrdersDataTable()
        {
            DataTable ordersdatatable = LoadOrderTable();

            Random r = new Random();
            ordersdatatable.Columns.Add("Price" );

            foreach (DataRow row in ordersdatatable.Rows)
            {
                row["Price"] = r.Next(1000, 10000);
            }
            return ordersdatatable;
        }

        public static DataTable GetOrdersDataTable()
        {
            return FormatOrdersDataTable();
        }

        // Customers
        public static DataTable LoadCustomersDataTable()
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
                }
            }

            return customersDataTable;
        }

        private static DataTable FormatCustomersDataTable()
        {
            DataTable customersDataTable = LoadCustomersDataTable();
            customersDataTable.Columns.Remove("Notes");
            customersDataTable.Columns["CustomerID"].ColumnName = "ID";
            customersDataTable.Columns["StrengthRight"].ColumnName = "SR";
            customersDataTable.Columns["StrengthLeft"].ColumnName = "SL";
            customersDataTable.Columns["Adress"].ColumnName = "Address";

            return customersDataTable;
        }

        public static DataTable GetCustomersDataTable()
        {
            return FormatCustomersDataTable();
        }

        //Products

        public static DataTable GetProductsDataTable()
        {
            var ProductTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(SQLConnecter.Connect()))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    com.CommandText = "SelectAllProducts";
                    com.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    ProductTable.Load(reader);
                }
            }
            return ProductTable;
        }



    }
}