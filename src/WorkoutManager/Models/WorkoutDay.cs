using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class WorkoutDay
    {
        public int WorkoutDayID { get; set; }

        public string Name { get; set; }

        public int DayOrder { get; set; }

        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
