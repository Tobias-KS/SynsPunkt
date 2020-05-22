using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.CRUD.CRUDorder
{
    public class ReaderOrder
    {
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
            DataTable orderDatatable = LoadOrderTable();
            orderDatatable.Columns.Add("Price");
            return orderDatatable;
        }

        public static DataTable GetOrderDataTable()
        {
            return FormatOrdersDataTable();
        }


    }
}