using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class WorkoutSetTemplate
    {
        public int ID { get; set; }

        public int WorkoutDayTemplateID { get; set; }

        public virtual WorkoutDayTemplate WorkoutDayTemplate { get; set; }

        public int ExerciseID { get; set; }

        public virtual Exercise Exercise { get; set; }

        public int Repetitions { get; set; }

        public bool? WeightBasedOnTrainingMax { get; set; }

        public double? WeightPercentageOfTrainingMax { get; set; }

        public bool AMRAPSet { get; set; }

        public bool WarmupSet { get; set; }
    }
}
