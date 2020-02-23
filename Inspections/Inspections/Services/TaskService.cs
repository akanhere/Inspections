using Inspections.Common;
using Inspections.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspections.Services
{
    public class TaskService : ITaskService
    {
        private List<Task> _tasks;
        public IList<Task> GetTasks()
        {
            _tasks = new List<Task>{
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 1", Status=Constants.TASK_STATUS_OPEN},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at A Building", Status = Constants.TASK_STATUS_CLOSED},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 2", Status = Constants.TASK_STATUS_COMPLETED, AssignedTo="Ashwin"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at B Building", Status = Constants.TASK_STAUTS_ASSIGNED, AssignedTo="John"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 3", Status = Constants.TASK_STATUS_IN_PROGRESS, AssignedTo="Jane"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at C Building", Status = Constants.TASK_STATUS_IN_PROGRESS, AssignedTo="Jane"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 4", Status = Constants.TASK_STATUS_COMPLETED, AssignedTo="Ashwin"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at D Building", Status = Constants.TASK_STATUS_OPEN},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Cleaning of WC 5", Status = Constants.TASK_STATUS_CLOSED, AssignedTo="Ashwin"},
                    new Task{ID = Guid.NewGuid().ToString(), TaskDescription = "Repair Work at E Building", Status = Constants.TASK_STATUS_OPEN}

                };
            return _tasks;

        }

        public int GetAllUnassignedTasksCount()
        {
            return _tasks.FindAll(t => string.IsNullOrEmpty(t.AssignedTo)).Count;
        }

        public int GetAllCompletedTasks()
        {
            return _tasks.FindAll(t => ( t != null && t.Status == Constants.TASK_STATUS_COMPLETED)).Count;
        }

        public int GetAllInProgressTasks()
        {
            return _tasks.FindAll(t => (t != null && t.Status == Constants.TASK_STATUS_IN_PROGRESS)).Count;
        }


    }
}
