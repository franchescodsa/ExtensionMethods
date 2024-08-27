using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extentions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisobj)
        {
            TimeSpan durations = DateTime.Now.Subtract(thisobj);
            if (durations.TotalHours <24.0)
            {
                return durations.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return durations.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + "days";
            }

        }
    }
}
