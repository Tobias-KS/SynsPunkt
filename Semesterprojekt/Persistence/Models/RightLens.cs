using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class RightLens
    {
        public int RightLensID { get; set; }
        public int CustomerID { get; set; }
        public double Strength { get; set; }
        public decimal LensPrice { get; set; }
    }
}
