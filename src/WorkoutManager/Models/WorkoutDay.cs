using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class WorkoutDay
    {
        public int ID { get; set; }

        public int WorkoutProgramID { get; set; }

        public string Name { get; set; }

        public int DayOrder { get; set; }
    }
}
