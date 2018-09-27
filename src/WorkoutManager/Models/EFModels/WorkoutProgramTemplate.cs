using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutManager.Models.EFModels
{
    public class WorkoutProgramTemplate
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<WorkoutDayTemplate> WorkoutDayTemplates { get; set; }
    }
}
