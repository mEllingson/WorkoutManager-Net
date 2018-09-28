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
        public async Task<IActionResult> Index()
        {
            var service = new WorkoutService();
            var programs = await service.GetPrograms();
            var workoutDays = await service.GetBasicWorkoutDayInfo(1);
            var fullworkoutDays = await service.GetFullWorkoutLayout(1);


            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
