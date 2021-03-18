using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using Project1.Models.ViewModels;
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
            IEnumerable<AvailableTimes> AllTimes = new List<AvailableTimes>();
            DateTime today = DateTime.Now;                                

            List<DateTime> datesList = new List<DateTime>();

            for (int i = today.Day; i < today.Day + 7; i++)
            {
                for (int j = 8; j <= 20; j++)
                {
                    datesList.Add(new DateTime(today.Year, today.Month, i, j, 0, 0));
                }
            }

            //going to compare with the repository work, and then if it doesn't match it will be marked true. otherwise, false

            return View();
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

            return View(new SignUpViewModel
            {
                SignUps = _repository.SignUps
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
