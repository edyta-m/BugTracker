using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BugTrackerApp.Models
{
    public class Bug
    {
        public int bugId { get; set; }
        public string bugName { get; set; }
        public string severity { get; set; }
        public DateTime timeReported { get; set; }
        public string programBehaviour { get; set; }
        public string reproduceBehaviour { get; set; }
    }

    public class BDBContext : DbContext
    {
        public BDBContext() { }
        public DbSet<Bug> Bugs { get; set; }
    }
}