using BrightAkademie.Business.Abstract;
using BrightAkademie.Business.Concrete;
using BrightAkademie.Shared.ControllerBases;
using BrightAkademie.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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
        public async Task<IActionResult> GetByIdCourses(int id)
        {
            var response = await _courseManager.GetCourseByIdAsync(id);
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourses(CourseCreateDto courseCreateDto)
        {
            var response = await _courseManager.CreateAsync(courseCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("/api/[controller]/GetCoursesByCategory/{categoryId}")]
        public async Task<IActionResult> GetCoursesByCategory(int categoryId)
        {
            var response = await _courseManager.GetCoursesByCategoryAsync(categoryId);
            return CreateActionResult(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourses(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseManager.UpdateAsync(courseUpdateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletCourses(int id)
        {
            var response = await _courseManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}
