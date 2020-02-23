using Inspections.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspections
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskDashboardView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
