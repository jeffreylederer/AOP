using System;
using System.Collections.Generic;

namespace Location
{
    class Program
    {
        [LazyLoaderAspect]
        private static List<string> _holidayList = Holidays.GetHolidays();
        static void Main(string[] args)
        {
            string holidays = string.Join(",", _holidayList.ToArray());
            Console.WriteLine(holidays);
            Console.WriteLine("");
            string holidays_again = string.Join(",", _holidayList.ToArray());
            Console.WriteLine(holidays_again);
            Console.ReadKey();
        }
    }
}
