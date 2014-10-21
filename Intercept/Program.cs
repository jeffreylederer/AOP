using System;

namespace Intercept
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = new Holidays();
            Console.WriteLine(holidays.GetHolidays());
            Console.WriteLine(holidays.GetHoliday("THANKSGIVING"));
            Console.WriteLine(holidays.GetHoliday("WEASELWACKINGDAY"));
            Console.WriteLine(holidays.IsHoliday("WEASELWACKINGDAY"));
            Console.ReadKey();
        }
    }
}
