using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Location
{
    public static class Holidays
    {
        
        public static List<string> GetHolidays()
        {
            var service = new USHolidayService();
            DataSet ds = service.GetHolidaysAvailable();
            return (from DataRow row in ds.Tables[0].Rows select (string) row["Name"]).ToList();
        }

       
        
    }
}
