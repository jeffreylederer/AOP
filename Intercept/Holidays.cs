using System.Collections.Generic;
using System.Data;


namespace Intercept
{
    public class Holidays
    {
        private USHolidayService _service;

        public Holidays()
        {
            _service = new USHolidayService();
        }

        [RetryOnExceptionAttribute(MaxRetries = 3)]
        public string GetHolidays()
        {
            var list = new List<string>();
            DataSet ds = _service.GetHolidaysAvailable();
            foreach (DataRow row in ds.Tables[0].Rows)
                list.Add((string) row["Name"]);
            return string.Join(",", list.ToArray());
        }

        [ExceptionAspect(AspectPriority=2)]
        [RetryOnExceptionAttribute(MaxRetries = 2, AspectPriority = 1)]
        public string GetHoliday(string holiday)
        {
            return string.Format("{0}: {1}", holiday, _service.GetHolidayDate(holiday, 2014).ToShortDateString());
        }

        public bool IsHoliday(string holiday)
        {
            var list = new List<string>();
            DataSet ds = _service.GetHolidaysAvailable();
            foreach (DataRow row in ds.Tables[0].Rows)
                list.Add((string)row["Name"]);
            return list.Contains(holiday);
        }
        
    }
}
