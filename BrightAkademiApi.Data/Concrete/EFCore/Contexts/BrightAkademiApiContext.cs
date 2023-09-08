using BrightAkademiApi.Data.Concrete.EFCore.Configs;
using BrightAkademiApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademiApi.Data.Concrete.EFCore.Contexts
{
    public class BrightAkademiApiContext : DbContext
    {
        public BrightAkademiApiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CoursesCategories { get; set; }
        public DbSet<CourseTrainee> CourseTrainees { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Trainee> Traines { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
