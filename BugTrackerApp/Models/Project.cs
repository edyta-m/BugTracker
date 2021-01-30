using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BugTrackerApp.Models
{
    public class Project
    {
        public int projectId { get; set; }
        public string projectName { get; set; }
    }

    public class ProDBContext : DbContext
    {
        public ProDBContext() { }
        public DbSet<Project> Projects { get; set; }
    }
}