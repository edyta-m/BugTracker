using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BugTrackerApp.Models
{
    public class Person
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class PerDBContext : DbContext
    {
        public PerDBContext() { }
        public DbSet<Person> People { get; set; }
    }
}