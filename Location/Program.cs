using System;
using System.Collections.Generic;

namespace Location
{
    class Program
    {
        [LazyLoaderAspect]
        private readonly static List<string> HolidayList = Holidays.GetHolidays();
        
        static void Main(string[] args)
        {
            string holidays = string.Join(",", HolidayList.ToArray());
            Console.WriteLine(holidays);
            Console.WriteLine("");
            string holidaysAgain = string.Join(",", HolidayList.ToArray());
            Console.WriteLine(holidaysAgain);
            Console.ReadKey();
        }
    }
}
