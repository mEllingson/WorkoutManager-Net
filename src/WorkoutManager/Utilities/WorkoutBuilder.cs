using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Utilities
{
    public class WorkoutBuilder
    {


        private double GetSetWeight(double setPercentage, double baseWeight)
        {
            return Math.Floor((setPercentage*baseWeight) / 5.0) * 5.0;
        }
    }
}
