using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Persistence.CRUD;
using Persistence.Models;
namespace SQLTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = Reader.SelectAllCustomers();
            Customer customer = Reader.SelectCustomer();

            foreach (var cust in customers)
            {
                Console.Write(cust);
            }
            Console.WriteLine(customer);
            Console.ReadKey();
        }
    }
}
