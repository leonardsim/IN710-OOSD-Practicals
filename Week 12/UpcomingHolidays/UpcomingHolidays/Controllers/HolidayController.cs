using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using UpcomingHolidays.Models;

namespace UpcomingHolidays.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DaysToHoliday()
        {
            // Variables
            DateTime now = DateTime.Now;

            // Create a default object
            Holiday defaultHoliday = new Holiday("Queen's Birthday", new DateTime(2016, 6, 6), "/Images/queen.jpg");

            // Generate random numbers
            Random rand = new Random();
            int randNum = rand.Next(3);

            switch (randNum)
            {
                case 0: // Queen's Birthday
                    defaultHoliday = new Holiday("Queen's Birthday", new DateTime(2016, 6, 6), "/Images/queen.jpg");
                    break;
                case 1: // Halloween
                    defaultHoliday = new Holiday("Halloween", new DateTime(2016, 10, 31), "/Images/halloween.jpg");
                    break;
                case 2: // Boxing Day
                    defaultHoliday = new Holiday("Boxing Day", new DateTime(2016, 12, 26), "/Images/boxing-day.jpg");
                    break;
            }

            return View();
        }
    }
}