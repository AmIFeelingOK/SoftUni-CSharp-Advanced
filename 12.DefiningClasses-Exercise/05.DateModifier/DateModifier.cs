using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    class DateModifier
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int DayDifference()
        {
            TimeSpan difference = this.EndDate - this.StartDate;
            return difference.Days;
        }
    }
}
