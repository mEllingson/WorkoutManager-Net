using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkoutManager.DataAccess;

namespace WorkoutManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var result = HttpClientService.Instance.GetListItems<string>("workout/getprograms");

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
