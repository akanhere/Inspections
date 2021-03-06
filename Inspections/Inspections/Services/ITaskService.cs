﻿using Inspections.Models;
using System.Collections.Generic;

namespace Inspections.Services
{
    public interface ITaskService
    {
        IList<Task> GetTasks();
        int GetAllUnassignedTasksCount();
        int GetAllCompletedTasks();
        int GetAllInProgressTasks();
    }
}