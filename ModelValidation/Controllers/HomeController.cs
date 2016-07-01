using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelValidation.Controllers {
    public class HomeController : Controller {

        public ViewResult MakeBooking() {
            return View(new Appointment { DateTime = DateTime.Now });
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt) {

            //statements to store a new appointment in a 
            //repository would go here in a real project

            return View("Completed", appt);
        }
    }
}