using System;
using System.Collections.Generic;
using System.Linq;

namespace LastSundayKata
{
    public class LastSundayKata
    {
        public List<DateTime> LastSunday(DateTime input)
        {
            var lastSundays = GetListOfLastSundaysFor(input.Year);
            return lastSundays;
        }

        private List<DateTime> GetListOfLastSundaysFor(int year)
        {
            var date = GetNewDateTimeList();
            for (var month = 1; month <= 12; month++)
            {
                var lastSundayForMonth = GetLastSundayForCurrentMonth(year, month);
                date.Add(lastSundayForMonth);
            }
            return date;
        }

        private DateTime GetLastSundayForCurrentMonth(int year, int month)
        {
            var lastSundaysOfCurrentMonth = GetNewDateTimeList();
            var lastDayInMonth = GetNumberOfDaysInMonth(year, month);
            for (var day = 1; day <= lastDayInMonth; day++)
            {
                var dateOfCurrentMonth = GetNewDateTimeFor(year, month, day);
                if (IsSunday(dateOfCurrentMonth))
                {
                    lastSundaysOfCurrentMonth.Add(dateOfCurrentMonth);
                }
            }
            return lastSundaysOfCurrentMonth.LastOrDefault();
        }

        private  List<DateTime> GetNewDateTimeList()
        {
            return new List<DateTime>();
        }

        private DateTime GetNewDateTimeFor(int year, int month, int day = 1)
        {
            return new DateTime(year, month, day);
        }

        private bool IsSunday(DateTime dateOfCurrentMonth)
        {
            return GetDayOfWeek(dateOfCurrentMonth) == DayOfWeek.Sunday;
        }

        private  DayOfWeek GetDayOfWeek(DateTime dateOfCurrentMonth)
        {
            return dateOfCurrentMonth.DayOfWeek;
        }

        private  int GetNumberOfDaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
