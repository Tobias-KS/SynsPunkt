using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Forename { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public double StrengthRight { get; set; }
        public double StrengthLeft { get; set; }
        public string Notes { get; set; }
        public DateTime SignupDate { get; set; }
    }
}
