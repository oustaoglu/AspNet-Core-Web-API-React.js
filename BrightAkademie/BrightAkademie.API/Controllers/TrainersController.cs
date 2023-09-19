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
    public class TrainersController : CustomControllerBase
    {
        private readonly ITrainerService _trainerManager;

        public TrainersController(ITrainerService trainerManager)
        {
            _trainerManager = trainerManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrainers()
        {
            var response = await _trainerManager.GetAllAsync();
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdTrainers(int id)
        {
            var response = await _trainerManager.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainers(TrainerCreateDto trainerCreateDto)
        {
            var response = await _trainerManager.CreateAsync(trainerCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTrainers(TrainerUpdateDto trainerUpdateDto)
        {
            var response = await _trainerManager.UpdateAsync(trainerUpdateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTrainers(int id)
        {
            var response = await _trainerManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}
