using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerApp.Models
{
    public class BugModel
    {
        public string BugTitle { get; set; }
        public string Severity { get; set; }
        public string ProgramBehaviour { get; set; }
        public string ReproduceBehaviour { get; set; }
    }
}