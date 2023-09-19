﻿using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using BrightAkademie.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BrightAkademie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainesController : CustomControllerBase
    {
        private readonly ITraineeService _traineeManager;

        public TrainesController(ITraineeService traineeManager)
        {
            _traineeManager = traineeManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var response = await _traineeManager.GetAllAsync();
            return CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdTrainers(int id)
        {
            var response = await _traineeManager.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrainers(TraineeCreateDto traineeCreateDto)
        {
            var response = await _traineeManager.CreateAsync(traineeCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTrainers(TraineeUpdateDto traineeUpdateDto)
        {
            var response = await _traineeManager.UpdateAsync(traineeUpdateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTrainers(int id)
        {
            var response = await _traineeManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}