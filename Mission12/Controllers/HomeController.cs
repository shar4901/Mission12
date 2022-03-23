using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult AddAppointment(DateTime timeId)
        {
            ViewBag.TimeId = timeId;
            return View(new Appointment());
        }

        //for when the appointment information is submitted
        [HttpPost]
        public IActionResult AddAppointment(Appointment appointment, DateTime timeId)
        {

            //string timeId = form["TimeId"].ToString();
            //string timeId = Request["TimeId"].ToString();
            if (ModelState.IsValid)
            {
                repo.EditAppointment(appointment);
                repo.SaveAppointment(appointment, timeId );

                ViewBag.TimeId = timeId;

                return RedirectToAction("Index");
            }
            ViewBag.TimeId = timeId;
            return View();
        }

        //for when an appointment is edited
        [HttpGet]
        public IActionResult EditAppointment(DateTime timeId)
        {
            TimeSlot time = repo.Timeslots.Where(x => x.AppointmentDateTime == timeId).FirstOrDefault(); //Appointments.Single(x => x.AppointmentId == AppId);

            Appointment appointment = time.Appointment;

            ViewBag.TimeId = timeId;

            return View("AddAppointment", appointment);
        }

        [HttpGet]
        public IActionResult DeleteAppointment(int AppId)
        {
            repo.DeleteAppointment(AppId);


            return RedirectToAction("ViewAllAppointments");
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
