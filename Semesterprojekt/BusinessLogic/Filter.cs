﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Persistence.CRUD;
using Persistence.Models;


namespace BusinessLogic
{
    public class Filter
    {

        //Test
        public static DataTable FilterCustomers()
        {
            var result = Reader.GetCustomersDataTable().Rows.Cast<DataRow>()
                .Where(c => c.Field<string>("Forename") == "Homer");

            return result.CopyToDataTable<DataRow>();

        }


        public static DataTable SearchBar(DataTable inputTable, string inputText)
        {
           
            if (inputText.Equals(""))
            {
                return inputTable;
            }

            var searchedList = inputTable.Rows
                .Cast<DataRow>()
                .Where(row => row.ItemArray.Any(
                    c => c.ToString().IndexOf(inputText, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            if (searchedList.Count != 0)
            {
                return searchedList.CopyToDataTable();
            }
            else
            {
                var tempDataTable = inputTable.Clone();
                tempDataTable.Clear();
                return tempDataTable;
            }
        }

    }

}

