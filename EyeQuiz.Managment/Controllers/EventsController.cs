using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeQuiz.Managment.Controllers
{
    public class EventsController : Controller
    {
        public EventsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
