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
            //grabs all available time slots and saves to alltimeslots

            List<TimeSlot> allTimeslots = repo.Timeslots
                .Where(x => x.AppointmentId == null)
                .OrderBy(x => x.AppointmentDateTime)
                .ToList();

            ViewBag.AllTimeSlots = allTimeslots;
            return View();
        }

        public IActionResult Appointments()

        {
            List<TimeSlot> scheduledTimeSlots = repo.Timeslots
                .Where(x => x.AppointmentId != null)
                .OrderBy(x => x.AppointmentDateTime)
                .ToList();


            ViewBag.ScheduledTimeSlots = scheduledTimeSlots;
            return View();
        }

        //Grabs all appointments from repository
        public IActionResult ViewAllAppointments()
        {

            List<TimeSlot> AllAppointments  = repo.Timeslots
                .Where(x => x.AppointmentId != null)
                .OrderBy(x => x.AppointmentDateTime)
                .ToList();
            ViewBag.AllAppointments = AllAppointments;
            return View();
        }




        //for when first loading an exisiting appointting 
        [HttpGet]
        public IActionResult AddAppointment(int aptID)
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult AddAppointment(int aptID)
        //{
        //    return View();
        //}

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
