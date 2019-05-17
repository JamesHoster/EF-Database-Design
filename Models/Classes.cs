using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseDesign.Models
{
    public class Classes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public string Department { get; set; }
        //Added After Initial Migration
        public string Instructor { get; set; }
    }
}