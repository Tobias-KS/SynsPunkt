using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
    }
}
