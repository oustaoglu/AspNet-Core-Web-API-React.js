using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using BrightAkademie.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomControllerBase
    {
        private readonly ICourseService _courseManager;

        public CoursesController(ICourseService courseManager)
        {
            _courseManager = courseManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses() 
        {
            var response = await _courseManager.GetCoursesWithFullDataAsync(null,true);
            return CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourses(int id)
        {
            var response = await _courseManager.GetCourseByIdAsync(id);
            return CreateActionResult(response);
        }

        [HttpPost]
        [Route("/api/[controller]/SaveCourse")]
        public async Task<IActionResult> SaveCourse(CourseCreateDto courseCreateDto)
        {
            var response = await _courseManager.CreateAsync(courseCreateDto);
            return CreateActionResult(response);
        }

        [HttpGet]
        [Route("/api/[controller]/GetCoursesByCategory/{categoryId}")]
        public async Task<IActionResult> GetCoursesByCategory(int categoryId)
        {
            var response = await _courseManager.GetCoursesByCategoryAsync(categoryId);
            return CreateActionResult(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseManager.UpdateAsync(courseUpdateDto);
            return CreateActionResult(response);
        }
    }
}
