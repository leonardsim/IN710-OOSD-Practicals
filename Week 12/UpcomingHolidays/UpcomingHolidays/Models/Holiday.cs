using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpcomingHolidays.Models
{
    public class Holiday
    {
        // Properties
        public string Name { get; set; }
        public DateTime HolidayDate { get; set; }
        public int NumDaysToHoliday { get; set; }
        public string ImageName { get; set; }

        // Constructor
        public Holiday (string name, DateTime holidayDate, string imageName)
        {
            Name = name;
            HolidayDate = holidayDate;
            ImageName = imageName;

            NumDaysToHoliday = 0;
        }
    }
}