using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models.EFModels
{
    public class ExerciseType
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
