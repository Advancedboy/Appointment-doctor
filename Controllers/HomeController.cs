using AppointmentDoctor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;

namespace AppointmentDoctor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(PatientResponse patientResponse)
        {
            if (ModelState.IsValid)
            {
                Archive.AddResponse(patientResponse);
                return View("Thanks", patientResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Archive.Responses.Where(r => r.Date != null));
        }
    }
}
