using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using BrightAkademie.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BrightAkademie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _categoryManager.GetAllAsync();
            if (!response.IsSucceeded)
            {
                return NotFound();
            }
            var jsonResult = JsonSerializer.Serialize(response);
            return Ok(jsonResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            //if (!response.IsSucceeded)
            //{
            //    return NotFound();
            //}
            var jsonResult = JsonSerializer.Serialize(response);
            return Ok(jsonResult);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
        {
            var response = await _categoryManager.CreateAsync(categoryCreateDto);
            return CreateActionResult(response);
        }
    }
}
