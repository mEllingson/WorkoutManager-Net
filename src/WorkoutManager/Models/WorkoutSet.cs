using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models
{
    public class WorkoutSet
    {
        public int SetID { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public bool UseTM { get; set; } //Calculate weight based on training max
        public double? TmPercent { get; set; }
        public bool AMRAPSet { get; set; }
        public bool WarmupSet { get; set; }
    }
}
