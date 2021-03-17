using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ISignUpRepository _repository;
        public int iPageSize = 12;

        public HomeController(ILogger<HomeController> logger, ISignUpRepository repo)
        {
            _repository = repo; 
            _logger = logger;
        }

        public IActionResult Index()
        {     
            // return the index view with some basic data
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AvailableTime(int iPageNum = 1)
        {                        
            //get today's date to write in all the times
            DateTime today = DateTime.Now;

            //make a list of available time classes, don't set the IsAvailable attribute yet - use the view model TimeSlot.cs
            List<TimeSlot> datesList = new List<TimeSlot>();

            //this loop will go through and add all the times to the list that we will generate to show a week schedule
            for (int i = today.Day; i < today.Day + 20; i++)
            {
                for (int j = 8; j <= 20; j++)
                {
                    //make sure that we're keeping the days/months/years accurate
                    DateTime nextDay = today.AddDays(i);
                    
                    //could use a separate class that just has a time and a bool with it, simplifying it and it wouldn't be included in the database - just for the view
                    DateTime nextDateTime = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, j, 0, 0);

                    //if we use this class, whic I'm not sure i'm going to do
                    AvailableTimes Availtime = new AvailableTimes();                    

                    Availtime.SelectedDate = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, j, 0, 0);
                    Availtime.SelectTime = new TimeSpan(j);

                    //datesList.Add(Availtime); //this will be used if we stick with using the available times class
                    datesList.Add(new TimeSlot(nextDateTime));                                            
                }
            }

            //go through this loop for each item in the signups repo and compare with the dates listed - if they are the same, then the dates rendered in the view will be unavailable - else, available
            foreach(var ScheduledDay in _repository.SignUps)
            {
                foreach(var NormalDay in datesList)
                {
                    if (DateTime.Compare(ScheduledDay.availableTimes, NormalDay.DateTimeSlot) == 0 || DateTime.Compare(NormalDay.DateTimeSlot, DateTime.Now) <= 0)
                    {
                        NormalDay.IsAvailable = false;
                    }
                    else
                    {
                        NormalDay.IsAvailable = true;
                    }
                }
            }
            //going to compare with the repository work, and then if it doesn't match it will be marked true. otherwise, false

            return View(datesList);
        }

        [HttpPost]
        public IActionResult AvailableTime(SignUpModel appResponse)
        {
            return View("GroupForm", appResponse);
        }

        [HttpGet]
        public IActionResult GroupForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GroupForm(SignUpModel appResponse)
        {
            return View("Index", appResponse);
        }

        public IActionResult ViewAppointments()
        {
            //need a model here with the correct appointment data, likely will include the date/time, name of group, size, email, and phone
            //will get this data and return to the view            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
