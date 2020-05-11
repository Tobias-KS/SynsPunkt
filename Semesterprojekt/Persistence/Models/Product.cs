using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public decimal Pris { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; }
        public string FrameType { get; set; }
        public string Glasstype { get; set; }
        public int LeftLensID { get; set; }
        public int RightLensID { get; set; }
        public string Productdescription { get; set; }

    }

}
