using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistence
{
    public class SqlConnectionTest
    {

        new void test()
        {
            SqlConnection conn = new SqlConnection("Server=den1.mssql7.gear.host;Database=odensedb;User ID=odensedb;Password=Ku9vy7Kax1--");
          
            SqlCommand testCommand = new SqlCommand("SelectAllCustomers", conn);

            testCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = testCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.Write(reader.Read());
                Console.ReadKey();
            }
        }

    }
}
