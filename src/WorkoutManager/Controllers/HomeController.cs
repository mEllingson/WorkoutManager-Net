using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WorkoutManager.DataAccess;
using WorkoutManager.Utilities;
using WorkoutManager.Models;
using WorkoutManager.ViewModels;

namespace WorkoutManager.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //var service = new WorkoutService();
            //List<FullWorkoutInfo> fullworkout = await service.GetFullWorkoutLayout(1);
            //var programs = await service.GetPrograms();
            //var workoutDays = await service.GetBasicWorkoutDayInfo(1);
            //var fullworkoutDays = await service.GetFullWorkoutLayout(1);
            //var builder = new WorkoutBuilder();
            //var test = await builder.GetFullWorkout(1);

            return View();
        }

        public async Task<IActionResult> FullWorkoutLayout()
        {
            var builder = new WorkoutBuilder();
            var viewModel = new FullWorkoutLayoutViewModel();
            viewModel.Program = await builder.GetFullWorkoutLayout(1);
            var day = builder.GetWorkoutLayout(viewModel.Program.WorkoutDays.Where(x => x.WorkoutDayID == 1).First(), 275);

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
