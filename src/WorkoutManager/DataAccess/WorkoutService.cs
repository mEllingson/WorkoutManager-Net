using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManager.Models;

namespace WorkoutManager.DataAccess
{
    public class WorkoutService
    {
        protected readonly WorkoutContext Context;

        public WorkoutService()
        {
            this.Context = new WorkoutContext();
        }

        public async Task<List<WorkoutProgram>> GetPrograms()
        {
            return await this.Context.WorkoutProgramTemplates.Select(x => new WorkoutProgram
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<List<WorkoutDay>> GetBasicWorkoutDayInfo(int id)
        {
            return await this.Context.WorkoutDayTemplates.Where(x => x.WorkoutProgramTemplateID == id).Select(x => new WorkoutDay
            {
                ID = x.ID,
                WorkoutProgramID = x.WorkoutProgramTemplateID,
                Name = x.Name,
                DayOrder = x.DayOrder
            }).ToListAsync();
        }

        public async Task<object> GetFullWorkoutLayout(int workoutID)
        {
            return await this.Context.WorkoutSetTemplates.Include("WorkoutDayTemplates").Include("Exercise").Include("Exercise.ExerciseType").Where(x => x.WorkoutDayTemplate.WorkoutProgramTemplateID == workoutID).Select(x => new {
                workoutDayTemplateID = x.WorkoutDayTemplate.ID,
                workoutDayTemplateName = x.WorkoutDayTemplate.Name,
                id = x.ID,
                exercise = x.Exercise.Name,
                exerciseType = x.Exercise.ExerciseType.Name,
                reps = x.Repetitions,
                useTM = x.WeightBasedOnTrainingMax ?? false,
                tmPercent = x.WeightPercentageOfTrainingMax ?? 0.0,
                amrapSet = x.AMRAPSet,
                warmupSet = x.WarmupSet
            }).GroupBy(x => x.workoutDayTemplateID).ToListAsync();
        }

        public async Task<object> GetWorkoutSets(int id)
        {
            return await this.Context.WorkoutSetTemplates.Include("Exercise").Include("Exercise.ExerciseType").Where(x => x.WorkoutDayTemplateID == id).Select(x => new
            {
                id = x.ID,
                exercise = x.Exercise.Name,
                exerciseType = x.Exercise.ExerciseType.Name,
                reps = x.Repetitions,
                useTM = x.WeightBasedOnTrainingMax ?? false,
                tmPercent = x.WeightPercentageOfTrainingMax ?? 0.0,
                amrapSet = x.AMRAPSet,
                warmupSet = x.WarmupSet
            }).ToListAsync();
        }
    }
}
