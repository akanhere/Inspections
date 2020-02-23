using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Inspections.ViewModels
{
    public class ManagerTaskStatsViewModel : BindableObject
    {
        public string DisplayStatusText { get; set; }
        public string Count { get; set; }

        public string Status { get; set; } //used for color converter
    }
}
