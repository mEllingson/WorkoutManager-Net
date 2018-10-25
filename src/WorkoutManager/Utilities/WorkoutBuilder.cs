using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManager.DataAccess;
using WorkoutManager.Models;

namespace WorkoutManager.Utilities
{
    public class WorkoutBuilder
    {
        public async Task<WorkoutProgram> GetFullWorkoutLayout(int workoutID)
        {
            var service = new WorkoutService();

            var program = new WorkoutProgram();
            program.ID = workoutID;
            program.Name = "blahhhh";
            program.WorkoutDays = new List<WorkoutDay>();

            List<FullWorkoutInfo> fullworkout = await service.GetFullWorkoutLayout(workoutID);

            //group by workout day
            var workoutDays = fullworkout.GroupBy(x =>  x.WorkoutDayTemplateID );

            var workoutDayList = new List<WorkoutDay>();
            foreach (var day in workoutDays)
            {
                var workoutDay = new WorkoutDay();
                workoutDay.WorkoutDayID = day.Key;
                workoutDay.Name = day.First().WorkoutDayTemplateName;
                workoutDay.DayOrder = day.First().WorkoutDayTemplateDayOrder;
                workoutDay.WorkoutExercises = new List<WorkoutExercise>();

                //Group by exercise (in each workout day)
                var workoutDayExercises = day.GroupBy(x => x.ExerciseID);

                
                foreach(var exercise in workoutDayExercises)
                {
                    var workoutExercise = new WorkoutExercise();
                    workoutExercise.ExerciseID = exercise.First().ExerciseID;
                    workoutExercise.ExerciseName = exercise.First().Exercise;
                    workoutExercise.ExerciseTypeID = exercise.First().ExerciseTypeID;
                    workoutExercise.ExerciseType = exercise.First().ExerciseType;

                    var setList = exercise.Select(x => new WorkoutSet
                    {
                        SetID = x.SetID,
                        Reps = x.Reps,
                        Weight = 0, //Calculate this later?
                        UseTM = x.UseTM.HasValue ? x.UseTM.Value : false,
                        TmPercent = x.TMPercent,
                        AMRAPSet = x.AMRAPSet.HasValue ? x.AMRAPSet.Value : false,
                        WarmupSet = x.WarmupSet.HasValue ? x.WarmupSet.Value : false
                    });
                    workoutExercise.ExerciseSets = setList;
                    workoutDay.WorkoutExercises.Add(workoutExercise);
                }
                workoutDayList.Add(workoutDay);
                
            }
            //order by day order
            program.WorkoutDays = workoutDayList.OrderBy(x => x.DayOrder);

            return program;
        }


        private double GetSetWeight(double setPercentage, double baseWeight)
        {
            return Math.Floor((setPercentage*baseWeight) / 5.0) * 5.0;
        }
    }
}
