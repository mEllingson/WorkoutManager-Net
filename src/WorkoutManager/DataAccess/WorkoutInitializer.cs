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
            new Exercise { Name = "Cable Curl", ExerciseTypeID = 3 },
            new Exercise { Name = "Lat Pulldown", ExerciseTypeID = 3 },
            new Exercise { Name = "Ab Wheel", ExerciseTypeID = 3 },
            new Exercise { Name = "Dumbbell Bench Press", ExerciseTypeID = 3 },
            new Exercise { Name = "Dips", ExerciseTypeID = 3 },
            new Exercise { Name = "Single Leg Press", ExerciseTypeID = 3 },
            new Exercise { Name = "Back Raise (Hyperextension)", ExerciseTypeID = 3 },
            };
            exercises.ForEach(s => context.Exercises.Add(s));
            context.SaveChanges();

            //Squat day
            var squatDaySets = new List<WorkoutSetTemplate>
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
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 1, AMRAPSet = false, WarmupSet = false },

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
            squatDaySets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();

            //OHP Day

            var ohpDaySets = new List<WorkoutSetTemplate>
            {
            //OHP
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 40, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 50, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 60, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = true },

                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 75, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 85, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },

                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 4, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },

                //Kroc Row
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },

                //Single Leg Press
                new WorkoutSetTemplate { ExerciseID = 13, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 13, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 13, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 13, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 13, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },

                //Hammer Curls
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },

                //Dips
                new WorkoutSetTemplate { ExerciseID = 12, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 12, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 12, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 12, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 12, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 2, AMRAPSet = false, WarmupSet = false }
            };
            ohpDaySets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();

            //Deadlift Day

            var deadliftDaySets = new List<WorkoutSetTemplate>
            {
            //Deadlifts
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 40, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 50, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 60, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = true },

                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 75, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 85, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },

                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 2, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },

            //Back Raise
                new WorkoutSetTemplate { ExerciseID = 14, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 14, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 14, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 14, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 14, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },

            //Lat Pulldown
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 9, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
            //Incline DB Press
                new WorkoutSetTemplate { ExerciseID = 5, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 5, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 5, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 5, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 5, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 3, AMRAPSet = false, WarmupSet = false }
            };
            deadliftDaySets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();

            //Bench Day
            var benchDaySets = new List<WorkoutSetTemplate>
            {
            //Bench Press
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 40, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 50, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = true },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 60, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = true },

                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 75, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 85, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },

                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 3, Repetitions = 5, WeightBasedOnTrainingMax = true, WeightPercentageOfTrainingMax = 65, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },            

            //Kroc Row
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 6, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
            //Facepull
                new WorkoutSetTemplate { ExerciseID = 7, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 7, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 7, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 7, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 7, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
            //Cable Curls
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 8, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
            //Ab Wheel
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false },
                new WorkoutSetTemplate { ExerciseID = 10, Repetitions = 12, WeightBasedOnTrainingMax = false, WorkoutDayTemplateID = 4, AMRAPSet = false, WarmupSet = false }
            };
            benchDaySets.ForEach(s => context.WorkoutSetTemplates.Add(s));
            context.SaveChanges();
        }
    }
}
