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
    public class Reader
    {
        private static DataTable LoadCustomersDataTable() 
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

            return customersDataTable;
        }

        public static DataTable GetCustomersDataTable()
        {
            return FormatCustomersDataTable();
        }

    }
}