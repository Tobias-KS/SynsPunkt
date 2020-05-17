using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Persistence
{
    public class SQLConnecter
    {

        public static string Connect()
        {

            string conn = "Server=den1.mssql8.gear.host;Database=odensedb;User ID=odensedb;Password=Lv6b!!0E3563";

            return conn;

        }

        public static void SetupCorrectCulture()
        {
            var customCulture =
                (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();

            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
        }


        public static void ExecuteCommand(String StoredProcedureName)
        {
            var conn = new SqlConnection(Connect());
            conn.Open();
            var com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = StoredProcedureName;
            com.CommandType = CommandType.StoredProcedure;
            com.ExecuteNonQuery();
            conn.Close();
        }

    }
}
