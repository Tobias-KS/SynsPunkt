﻿using System.Data;
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
            ordersdatatable.Columns.Add("Price");
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

        public static DataTable LoadProductTable()
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