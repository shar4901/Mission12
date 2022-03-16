using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        //brings in the repostory

        private IAppointmentRepository repo;

      
        public HomeController(IAppointmentRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Signup()

        {
            //grabs all time slots and saves to alltimeslots

            List<TimeSlot> allTimeslots = repo.Timeslots.ToList();
            ViewBag.AllTimeSlots = allTimeslots;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
