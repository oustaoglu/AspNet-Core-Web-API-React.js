using BrightAkademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Abstract
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<bool> AnyAsync(int id);
        Task<List<Course>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null);
        Task<List<Course>> GetAllActiveCoursesAsync(string categoryUrl = null, string trainerUrl = null, string traineeUrl = null);
        Task<List<Course>> GetCoursesByCategoryAsync(int categoryId);
        Task<List<Course>> GetCoursesByTraineeAsync(int traineeId);
        Task<Course> GetCourseByUrlAsync(string courseUrl);
        Task<Course> GetCourseByIdAsync(int id);
        Task<List<Course>> GetAllCoursesWithTrainerAndTrainee(bool isDeleted);
        Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds);
        Task UpdateTrainerOfCourses();
        Task UpdateTraineeOfCourses();
        Task CheckCoursesCategories();
        void UpdateCourse(Course course);
    }
}
