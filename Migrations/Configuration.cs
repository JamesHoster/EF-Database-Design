namespace DatabaseDesign.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DatabaseDesign.Models;
    using DatabaseDesign.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseDesign.DAL.CollegeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseDesign.DAL.CollegeContext context)
        {
            context.Students.AddOrUpdate(x => x.ID,
                new Students() { ID = 1, FirstName = "James", LastName = "Hoster", SSN = 123, Phone = 223, Address = "1234 Main", City = "Cleveland", State = "Ohio", Zip = 44111 },
                new Students() { ID = 2, FirstName = "Thomas", LastName = "Hoster", SSN = 432, Phone = 332, Address = "1255 South St.", City = "Columbus", State = "Ohio", Zip = 44838},
                new Students() { ID = 3, FirstName = "Randy", LastName = "Quaid", SSN = 455, Phone = 989, Address = "656 Fox Ln.", City = "Chicago", State = "Illinios", Zip = 65747 }
                );
            context.Classes.AddOrUpdate(x => x.ID,
                new Classes() { ID = 1, Title = "Algebra 1", Number = 101, Department = "Math" },
                new Classes() { ID = 2, Title = "Physics", Number = 222, Department = "Science"},
                new Classes() { ID = 3, Title = "Painting", Number = 621, Department ="Arts"}
                );
            context.Scores.AddOrUpdate(x => x.ID,
                new Scores() { ID = 1, Type = "HW", Description = "HW One", DateAssigned = DateTime.Now, DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsPossible = 10, PointsEarned = 9 },
                new Scores() { ID = 2, Type = "Lab", Description = "Lab One", DateAssigned = DateTime.Now, DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsPossible = 100, PointsEarned = 82 },
                new Scores() { ID = 3, Type = "Test", Description = "Test One", DateAssigned = DateTime.Now, DateDue = DateTime.Now, DateSubmitted = DateTime.Now, PointsPossible = 50, PointsEarned = 45}
                );
        }
    }
}
