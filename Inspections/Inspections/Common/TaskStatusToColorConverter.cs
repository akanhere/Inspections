using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Inspections.Common
{
    public class TaskStatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value as string;
            if (string.IsNullOrEmpty(status) == false)
            {
                
                switch (status)
                {
                    case Constants.TASK_STATUS_OPEN:
                        return "#E55023";
                    case Constants.TASK_STATUS_IN_PROGRESS:
                        return "#F3A348";
                    case Constants.TASK_STATUS_COMPLETED:
                        return "#1CA64C";

                }
            }
            return Xamarin.Forms.Color.LawnGreen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
