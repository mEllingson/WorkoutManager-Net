using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManager.Models.EFModels;

namespace WorkoutManager.DataAccess
{
    public class WorkoutInitializer : System.Data.Entity.DropCreateDatabaseAlways<WorkoutContext>
    {
        protected override void Seed(WorkoutContext context)
        {
            var program = new WorkoutProgramTemplate() { Name = "5/3/1 5's Pro (5x5 FSL)" };
            context.WorkoutProgramTemplates.Add(program);
            context.SaveChanges();

            var days = new List<WorkoutDayTemplate>
            {
                new WorkoutDayTemplate { Name = "Overhead Press Day", DayOrder = 1, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Squat Day", DayOrder = 2, WorkoutProgramTemplateID = 1 },
                new WorkoutDayTemplate { Name = "Deadlift Day", DayOrder = 3, WorkoutProgramTemplateID = 1 },
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
            new Exercise { Name = "Incline Dumbbell Bench Press", ExerciseTypeID = 3 },
            new Exercise { Name = "Kroc Row", ExerciseTypeID = 3 },
            new Exercise { Name = "Facepull", ExerciseTypeID = 3 },
            new Exercise { Name = "Hammer Curl", ExerciseTypeID = 3 },
            new Exercise { Name = "Lat Pulldown", ExerciseTypeID = 3 },
            new Exercise { Name = "Ab Wheel", ExerciseTypeID = 3 },
            new Exercise { Name = "Dumbbell Bench Press", ExerciseTypeID = 3 },
            new Exercise { Name = "Dips", ExerciseTypeID = 3 },
            new Exercise { Name = "Single Leg Press", ExerciseTypeID = 3 },
            new Exercise { Name = "Back Raise (Hyperextension)", ExerciseTypeID = 3 },
            };
            exercises.ForEach(s => context.Exercises.Add(s));
            context.SaveChanges();

            var sets = new List<WorkoutSetTemplate>
            {
                // Squat
               new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 40, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 50, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 60, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = true },

                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 75, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 85, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                // Lat pulldown
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                // Dumbell Bench
                new WorkoutSetTemplate { ExerciseID = 11, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 11, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 11, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 11, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 11, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

                // Ab Wheel
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false }
            };
            sets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();
        }
    }
}
