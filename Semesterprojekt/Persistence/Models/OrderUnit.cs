using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class OrderUnit
    {
        public int OrderUnitID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
    }
}
