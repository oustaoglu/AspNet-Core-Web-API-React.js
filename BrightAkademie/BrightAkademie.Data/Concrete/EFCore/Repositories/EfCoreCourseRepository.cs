using BrightAkademie.Data.Abstract;
using BrightAkademie.Data.Concrete.EFCore.Contexts;
using BrightAkademie.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Concrete.EFCore.Repositories
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course>, ICourseRepository
    {
        public EfCoreCourseRepository(BrightAkademieContext _context) : base(_context)
        {
        }
        private BrightAkademieContext Context
        {
            get { return _dbContext as BrightAkademieContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context
                .Courses
                .AnyAsync(x => x.Id == id);
        }

        public async Task CheckCoursesCategories()
        {
            var courseCategoryIds = await Context
                .CoursesCategories
                .Select(c => c.CourseId)
                .Distinct()
                .ToListAsync();
            var courseIds = await Context
                .Courses
                .Select(c => c.Id)
                .ToListAsync();
            List<int> different = courseIds.Except(courseCategoryIds).ToList();

            await Context.CoursesCategories.AddRangeAsync(different.Select(c => new CourseCategory
            {
                CourseId = c,
                CategoryId = 1
            }).ToList());
            await Context.SaveChangesAsync();
        }

        public async Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds)
        {
            await Context.Courses.AddAsync(course);
            await Context.SaveChangesAsync();
            course.CourseCategories = SelectedCategoryIds.Select(sc => new CourseCategory
            {
                CourseId = course.Id,
                CategoryId = sc
            }).ToList();
            Context.Courses.Update(course);
            await Context.SaveChangesAsync();
        }

        public async Task<List<Course>> GetAllActiveCoursesAsync(string categoryUrl = null, string trainerUrl = null, string traineeUrl = null)
        {
            var result = Context
                 .Courses
                 .Where(c => c.IsActive && !c.IsDeleted)
                 //.Include(c => c.Trainee)
                 //.ThenInclude(c => c.Trainee)
                 .Include(c => c.Trainer)
                 .AsQueryable();
            if (categoryUrl != null)
            {
                result = result
                    .Include(c => c.CourseCategories)
                    .ThenInclude(cc => cc.Category)
                    .Where(c => c.CourseCategories.Any(cc => cc.Category.Url == categoryUrl))
                    .AsQueryable();
            }
            if (traineeUrl != null)
            {
                result = result
                    //.Where(c => c.Trainee.Any(cc => cc.Trainee.Url == traineeUrl))
                    //.Include(c => c.Trainee)
                    .AsQueryable();
            }
            if (trainerUrl != null)
            {
                result = result
                    .Where(c => c.Trainer.Url == trainerUrl)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Course>> GetAllCoursesWithTrainerAndTrainee(bool isDeleted)
        {
            var result = await Context
                  .Courses
                 .Where(c => c.IsDeleted == isDeleted)
                 //.Include(c => c.Trainee)
                 //.ThenInclude(cc => cc.Trainee)
                 .Include(c => c.Trainer)
                 .ToListAsync();
            return result;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var result = await Context
             .Courses
             .Where(c => c.IsActive && !c.IsDeleted && c.Id == id)
             .Include(c => c.CourseCategories).ThenInclude(cc => cc.Category)
             //.Include(c => c.Trainee)
             //ThenInclude(cc => cc.Trainee)
             .Include(c => c.Trainer)
             .FirstOrDefaultAsync();
            return result;
        }

        public async Task<Course> GetCourseByUrlAsync(string courseUrl)
        {
            var result = await Context
              .Courses
              .Where(c => c.IsActive && !c.IsDeleted && c.Url == courseUrl)
              .Include(c => c.CourseCategories)
              .ThenInclude(cc => cc.Category)
              //.Include(c => c.Trainee)
              //.ThenInclude(c => c.Trainee)
              .Include(c => c.Trainer)
              .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Course>> GetCoursesByCategoryAsync(int categoryId)
        {
            var result = await Context
             .Courses
             .Where(c => c.IsActive && !c.IsDeleted)
             .Include(c => c.CourseCategories)
             .ThenInclude(cc => cc.Category)
             .Where(x => x.CourseCategories.Any(x => x.CategoryId == categoryId))
             //.Include(c => c.Trainee)
             //.ThenInclude(cc => cc.Trainee)
             .Include(c => c.Trainer)
             .ToListAsync();
            return result;
        }

        public async Task<List<Course>> GetCoursesByTraineeAsync(int traineeId)
        {
            var result = await Context
              .Courses
              .Where(c => c.IsActive && !c.IsDeleted)
              //.Include(c => c.Trainee)
              //.ThenInclude(cc => cc.Trainee)
              //.Where(x => x.Trainee.Any(x => x.TraineeId == traineeId))
              //.Include(c => c.Trainee)
              .Include(c => c.Trainer)
              .ToListAsync();
            return result;
        }

        public async Task<List<Course>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null)
        {
            var result = Context
              .Courses
              .Where(c => !c.IsDeleted)
              .AsQueryable();

            if (isHome != null)
            {
                result = result
                    .Where(c => c.IsHome == isHome)
                    .AsQueryable();
            }

            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(c => c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                //.Include(c => c.Trainee)
                //.ThenInclude(cc => cc.Trainee)
                .Include(c => c.Trainer)
                .AsQueryable();

            return await result.ToListAsync();
        }

        public void UpdateCourse(Course course)
        {
            Course oldCourse = Context
                .Courses
                .Include(c => c.CourseCategories)
                .ThenInclude(cc => cc.Category)
                //.Include(b => b.Trainee)
                //.ThenInclude(cc => cc.Trainee)
                .Include(t => t.Trainer)
                .Where(c => c.Id == course.Id)
                .FirstOrDefault();
            oldCourse.Name = course.Name;
            oldCourse.Description = course.Description;
            oldCourse.Price = course.Price;
            oldCourse.Location = course.Location;
            oldCourse.Evaluation = course.Evaluation;
            oldCourse.CourseLevel = course.CourseLevel;
            oldCourse.Earnings = course.Earnings;
            oldCourse.Statues = course.Statues;
            oldCourse.TotalTime = course.TotalTime;
            oldCourse.Time = course.Time;
            oldCourse.Start = course.Start;
            oldCourse.End = course.End;
            oldCourse.IsActive = course.IsActive;
            oldCourse.IsHome = course.IsHome;
            oldCourse.IsDeleted = course.IsDeleted;
            oldCourse.TrainerId = course.TrainerId;
            oldCourse.Url = course.Url;
            oldCourse.ModifiedDate = DateTime.Now;
            //oldCourse.Trainee = course.Trainee;
            oldCourse.CourseCategories = course.CourseCategories;
            oldCourse.ImageUrl = course.ImageUrl;

            Context.Courses.Update(oldCourse);
            Context.SaveChanges();
        }

        public Task UpdateTraineeOfCourses()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTrainerOfCourses()
        {
            {
                var courses = await Context
                    .Courses
                    .Where(b => b.TrainerId == null)
                    .ToListAsync();
                foreach (var course in courses)
                {
                    course.TrainerId = 1;
                };
                Context.Courses.UpdateRange(courses);
                await Context.SaveChangesAsync();
            }
        }
    }
}
