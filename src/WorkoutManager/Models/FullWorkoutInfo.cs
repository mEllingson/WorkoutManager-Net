using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class FullWorkoutInfo
    {
        public int WorkoutDayTemplateID { get; set; }
        public string WorkoutDayTemplateName { get; set; }
        public int WorkoutDayTemplateDayOrder { get; set; }
        public int ID { get; set; }
        public int ExerciseID { get; set; }
        public string Exercise { get; set; }
        public int ExerciseTypeID { get; set; }
        public string ExerciseType { get; set; }
        public int SetID { get; set; }
        public int Reps { get; set; }
        public bool? UseTM { get; set; }
        public double TMPercent { get; set; }
        public bool? AMRAPSet { get; set; }
        public bool? WarmupSet { get; set; }
    }
}
