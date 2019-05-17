using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseDesign.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
    }
}