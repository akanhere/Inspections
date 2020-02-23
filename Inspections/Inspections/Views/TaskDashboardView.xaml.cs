using Inspections.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspections.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDashboardView : ContentPage
    {
        public TaskDashboardView()
        {
            InitializeComponent();
            this.BindingContext = new TaskDashboardViewModel();
         
        }
    }
}