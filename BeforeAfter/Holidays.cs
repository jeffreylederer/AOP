using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BeforeAfter
{
    [ExecutionDurationAspect]
    public class Holidays
    {
        private readonly USHolidayService _service;

        public Holidays()
        {
            _service = new USHolidayService();
        }
        public string GetHolidays()
        {
            DataSet ds = _service.GetHolidaysAvailable();
            return string.Join(",", (from DataRow row in ds.Tables[0].Rows select (string) row["Name"]).ToArray());
        }

        public string GetHoliday(string holiday)
        {
            return string.Format("{0}: {1}", holiday, _service.GetHolidayDate(holiday, 2014).ToShortDateString());
        }

        [ExecutionDurationAspect(AttributeExclude = true)]
        public bool IsHoliday(string holiday) 
        {
            DataSet ds = _service.GetHolidaysAvailable();
            var list = (from DataRow row in ds.Tables[0].Rows select (string) row["Name"]).ToList();
            return list.Contains(holiday);
        }
    }
}
