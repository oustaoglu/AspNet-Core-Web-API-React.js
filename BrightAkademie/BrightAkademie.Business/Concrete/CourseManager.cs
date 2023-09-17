using BrightAkademie.Business.Abstract;
using BrightAkademie.Entity.Concrete;
using BrightAkademie.Shared.DTOs;
using BrightAkademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        public Task CheckCoursesCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateCourseAsync(Course course, List<int> SelectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetAllActiveCoursesAsync(string categoryUrl = null, string trainerUrl = null, string traineeUrl = null)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetAllCoursesWithTrainerAndTrainee(bool isDeleted)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CourseDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CourseDto>> GetCourseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CourseDto>> GetCourseByUrlAsync(string courseUrl)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetCoursesByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetCoursesByTraineeAsync(int traineeId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CourseDto>>> GetCoursesWithFullDataAsync(bool? isHome = null, bool? isActive = null)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTraineeOfCourses()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTrainerOfCourses()
        {
            throw new NotImplementedException();
        }
    }
}
