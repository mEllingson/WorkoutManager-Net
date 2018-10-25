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
                WorkoutDayID = x.ID,
                //WorkoutProgramID = x.WorkoutProgramTemplateID,
                Name = x.Name,
                DayOrder = x.DayOrder
            }).ToListAsync();
        }

        public async Task<List<FullWorkoutInfo>> GetFullWorkoutLayout(int workoutID)
        {
            return await this.Context.WorkoutSetTemplates.Include("WorkoutDayTemplates").Include("Exercise").Include("Exercise.ExerciseType").Where(x => x.WorkoutDayTemplate.WorkoutProgramTemplateID == workoutID).Select(x => new FullWorkoutInfo
            {
                WorkoutDayTemplateID = x.WorkoutDayTemplate.ID,
                WorkoutDayTemplateName = x.WorkoutDayTemplate.Name,
                WorkoutDayTemplateDayOrder = x.WorkoutDayTemplate.DayOrder,
                ID = x.ID,
                ExerciseID = x.Exercise.ID,
                Exercise = x.Exercise.Name,
                ExerciseTypeID = x.Exercise.ExerciseTypeID,
                ExerciseType = x.Exercise.ExerciseType.Name,
                SetID = x.ID,
                Reps = x.Repetitions,
                UseTM = x.WeightBasedOnTrainingMax ?? false,
                TMPercent = x.WeightPercentageOfTrainingMax ?? 0.0,
                AMRAPSet = x.AMRAPSet,
                WarmupSet = x.WarmupSet
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
