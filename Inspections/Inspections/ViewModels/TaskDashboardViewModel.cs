using Inspections.Models;
using Inspections.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inspections.ViewModels
{
    public class TaskDashboardViewModel : BindableObject
    {
        ITaskService _taskService;
        public TaskDashboardViewModel()
        {
            _taskService = new TaskService();
            InitCommands();
            InitProperties();


        }

        private void InitCommands()
        {
            CreateUserCommand = new Command(CreateNewUser, CanCreateNewUser);
            CreateGroupCommand = new Command(CreateNewGroup, CanCreateNewGroup);
            AssignTaskToUserCommand = new Command(AssignTaskToUser, CanAssignTaskToUser);
        }

        #region Commands
        private bool CanAssignTaskToUser(object arg)
        {
            return true;
        }

        private void AssignTaskToUser(object obj)
        {

        }

        private bool CanCreateNewGroup(object arg)
        {
            return true;
        }

        private void CreateNewGroup(object obj)
        {

        }

        private bool CanCreateNewUser(object arg)
        {
            return true;
        }

        private void CreateNewUser(object obj)
        {

        }

        public ICommand CreateUserCommand { get; set; }

        public ICommand CreateGroupCommand { get; set; }

        public ICommand AssignTaskToUserCommand { get; set; }

        #endregion


        #region Properties

        private void InitProperties()
        {
            LoadTasks();
        }
        public User CurrentUser { get; set; }

        public IList<Task> Tasks { get; set; }

        public int TotalTasks { get; private set; }

        public int TasksInProgress { get; private set; }

        public int TasksCompletedYesterday { get; private set; }

        public int TasksUnassigned { get; private set; }

        #endregion

        private void LoadTasks()
        {
            if (Tasks == null)
            {
                Tasks = new ObservableCollection<Task>(_taskService.GetTasks());

            }
        }

        private void GetUnassignedTasks()
        {

        }

        private void GetCompletedTasks()
        {

        }

        private void GetInProgressTasks()
        {

        }
    }
}
