using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class LeftLens
    {
        public int LeftLensID { get; set; }
        public int CustomerID { get; set; }
        public double Strength { get; set; }
        public decimal LensPrice { get; set; }
    }
}
