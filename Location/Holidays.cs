using System.Collections.Generic;
using System.Data;


namespace Location
{
    public static class Holidays
    {
        
        public static List<string> GetHolidays()
        {
            var service = new USHolidayService();
            var list = new List<string>();
            DataSet ds = service.GetHolidaysAvailable();
            foreach (DataRow row in ds.Tables[0].Rows)
                list.Add((string) row["Name"]);
            return list;
        }
        
    }
}
