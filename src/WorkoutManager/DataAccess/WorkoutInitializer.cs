using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManager.Models;

namespace WorkoutManager.DataAccess
{
    public class WorkoutInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WorkoutContext>
    {
        protected override void Seed(WorkoutContext context)
        {
            var program = new WorkoutProgramTemplate() { Name = "nSuns 5/3/1" };
            context.WorkoutProgramTemplates.Add(program);
            context.SaveChanges();

            var days = new List<WorkoutDayTemplate>
            {
                new WorkoutDayTemplate { Name = "Press Volume Day", DayOrder = 1, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Squat Day", DayOrder = 2, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Overhead Press Day", DayOrder = 3, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Deadlift Day", DayOrder = 4, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Bench Press Day", DayOrder = 5, WorkoutProgramTemplateID = 1 }
            };
            days.ForEach(s => context.WorkoutDayTemplates.Add(s));
            context.SaveChanges();

            var exerciseTypes = new List<ExerciseType>
            {
            new ExerciseType { Name = "Primary" },
            new ExerciseType { Name = "Secondary" },
            new ExerciseType { Name = "Accessory" }
            };
            exerciseTypes.ForEach(s => context.ExerciseTypes.Add(s));
            context.SaveChanges();

            var exercises = new List<Exercise>
            {
            new Exercise { Name = "Squat", ExerciseTypeID = 1 },
            new Exercise { Name = "Deadlift", ExerciseTypeID = 1 },
            new Exercise { Name = "Bench Press", ExerciseTypeID = 1 },
            new Exercise { Name = "Overhead Press", ExerciseTypeID = 1 },
            new Exercise { Name = "Pause Squat", ExerciseTypeID = 2 },
            new Exercise { Name = "Close grip Bench Press", ExerciseTypeID = 2 },
            new Exercise { Name = "Incline Bench Press", ExerciseTypeID = 2 },
            new Exercise { Name = "Sumo Deadlift", ExerciseTypeID = 2 },
            new Exercise { Name = "Kroc Row", ExerciseTypeID = 3 },
            new Exercise { Name = "Facepull", ExerciseTypeID = 3 },
            new Exercise { Name = "Overhead Tricep Extension", ExerciseTypeID = 3 },
            new Exercise { Name = "Hammer Curl", ExerciseTypeID = 3 },
            new Exercise { Name = "Lat Pulldown", ExerciseTypeID = 3 },
            };
            exercises.ForEach(s => context.Exercises.Add(s));
            context.SaveChanges();

            var sets = new List<WorkoutSetTemplate>
            {
                // Bench
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 4, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 90, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 4, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 90, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 4, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 90, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                // OHP
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 3, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 80, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 80, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 7, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 80, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                // Kroc Row
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 10, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 10, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 10, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false }
            };
            sets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();
        }
    }
}
