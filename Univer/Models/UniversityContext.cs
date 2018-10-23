using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Univer.Models
{
    public class UniversityContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }

    public class UniverDBInitializer : DropCreateDatabaseAlways<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            context.Students.Add(new Student { Name = "Vasya Pupkin", Faculty = "Law", Stipend = true, Year = 4 });

            base.Seed(context);
        }
    }
}