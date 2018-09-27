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

        public async Task<object> GetPrograms()
        {
            return await this.Context.WorkoutProgramTemplates.Select(x => new WorkoutProgram
            {
                ID = x.ID,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<object> GetWorkoutDays(int id)
        {
            return await this.Context.WorkoutDayTemplates.Where(x => x.WorkoutProgramTemplateID == id).Select(x => new WorkoutDay
            {
                ID = x.ID,
                WorkoutProgramID = x.WorkoutProgramTemplateID,
                Name = x.Name,
                DayOrder = x.DayOrder
            }).ToListAsync();
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
