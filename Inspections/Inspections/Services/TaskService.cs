using Inspections.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspections.Services
{
    public class TaskService : ITaskService
    {
        public IList<Task> GetTasks()
        {
            List<Task> tasks = new List<Task>{
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 1"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at A Building"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 2"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at B Building"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 3"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at C Building"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 4"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at D Building"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 5"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at E Building"}

                };
            return tasks;

        }

        

        
    }
}
