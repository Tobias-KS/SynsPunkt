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
        public static DataTable FilterCustomers()
        {
            var result = Reader.GetCustomersDataTable().Rows.Cast<DataRow>().Where(c => c.Field<string>("Forename") == "Homer");

            return result.CopyToDataTable<DataRow>();

            var filtered = tb.AsEnumerable()
                               .Where(r => r.Field<String>("FIRSTNAME").Contains(searchstring)
                                           || r.Field<String>("LASTNAME").Contains(searchstring))
                           || r.Field<String>("NAME").Contains(searchstring)
                           || r.Field<String>("COMPANY").Contains(searchstring)
                           || r.Field<String>("CREATOR").Contains(searchstring));
        }


        public static 


        
    }
}
