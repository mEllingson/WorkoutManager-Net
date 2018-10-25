using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class WorkoutExercise
    {
        public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        public int ExerciseTypeID { get; set; } // ? int vs name here?
        public string ExerciseType { get; set; }
        public IEnumerable<WorkoutSet> ExerciseSets { get; set; }

    }
}
