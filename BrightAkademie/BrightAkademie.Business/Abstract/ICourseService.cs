using BrightAkademie.Entity.Concrete;
using BrightAkademie.Shared.DTOs;
using BrightAkademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Abstract
{
    public interface ICourseService
    {
        #region Generic
        Task<Response<CourseDto>> GetByIdAsync(int id);
        Task<Response<List<CourseDto>>> GetAllAsync();
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion

        Task<Response<List<CourseDto>>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null);
        Task<Response<List<CourseDto>>> GetAllActiveCoursesAsync(string categoryUrl = null, string trainerUrl = null, string traineeUrl = null);
        Task<Response<CourseDto>> GetCourseByUrlAsync(string courseUrl);
        Task<Response<CourseDto>> GetCourseByIdAsync(int id);
        Task<Response<List<CourseDto>>> GetCoursesByCategoryAsync(int categoryId);
        Task<Response<List<CourseDto>>> GetCoursesByTraineeAsync(int traineeId);
        Task<Response<List<CourseDto>>> GetAllCoursesWithTrainerAndTrainee(bool isDeleted);

        Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds);
        Task UpdateTraineeOfCourses();
        Task UpdateTrainerOfCourses();
        Task CheckCoursesCategories();
        void UpdateCourse(Course course);
    }
}
