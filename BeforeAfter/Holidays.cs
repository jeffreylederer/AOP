using System.Collections.Generic;
using System.Data;


namespace BeforeAfter
{
    [ExecutionDurationAspect]
    public class Holidays
    {
        private USHolidayService _service;

        public Holidays()
        {
            _service = new USHolidayService();
        }
        public string GetHolidays()
        {
            var list = new List<string>();
            DataSet ds = _service.GetHolidaysAvailable();
            foreach (DataRow row in ds.Tables[0].Rows)
                list.Add((string) row["Name"]);
            return string.Join(",", list.ToArray());
        }

        public string GetHoliday(string holiday)
        {
            return string.Format("{0}: {1}", holiday, _service.GetHolidayDate(holiday, 2014).ToShortDateString());
        }

        [ExecutionDurationAspect(AttributeExclude = true)]
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
