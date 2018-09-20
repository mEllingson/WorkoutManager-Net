using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using WorkoutManager.Models;

namespace WorkoutManager.DataAccess
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext() : base("WorkoutContext")
        {
        }

        public DbSet<WorkoutProgramTemplate> WorkoutProgramTemplates { get; set; }

        public DbSet<WorkoutDayTemplate> WorkoutDayTemplates { get; set; }

        public DbSet<WorkoutSetTemplate> WorkoutSetTemplates { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<ExerciseType> ExerciseTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
