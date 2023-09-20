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
    public class SettingsController : CustomControllerBase
    {
        private readonly ISettingService _settingManager;

        public SettingsController(ISettingService settingManager)
        {
            _settingManager = settingManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetSettings()
        {
            var response = await _settingManager.GetAllAsync();
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdSettings(int id)
        {
            var response = await _settingManager.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSettings(SettingCreateDto settingCreateDto)
        {
            var response = await _settingManager.CreateAsync(settingCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSettings(SettingUpdateDto settingUpdateDto)
        {
            var response = await _settingManager.UpdateAsync(settingUpdateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSettings(int id)
        {
            var response = await _settingManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}
