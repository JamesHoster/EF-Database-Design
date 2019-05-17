using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DatabaseDesign.Models;

namespace DatabaseDesign.DAL
{
    public class CollegeContext : DbContext
    {
        public CollegeContext() : base("CollegeDBEF")
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Scores> Scores { get; set; }
    }
}