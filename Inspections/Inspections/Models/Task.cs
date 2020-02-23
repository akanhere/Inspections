using System;
using System.Collections.Generic;
using System.Text;

namespace Inspections.Models
{
    public class Task
    {
        public string ID { get; set; }
        public string TaskDescription { get; set; }
        public DateTime PrefferedExecutionDate { get; set; }
        public DateTime PrefferedExecutionTime { get; set; }
        public string AssignedTo { get; set; }

        public string Status { get; set; }
    }
}
