using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class AddonUnit
    {
        public int AddonUnitID { get; set; }
        public int AddonID { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
    }
}
