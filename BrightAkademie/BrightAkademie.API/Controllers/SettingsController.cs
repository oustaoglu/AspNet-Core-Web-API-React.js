using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAuthors()
        {
            var response = await _settingManager.GetAllAsync();
            return CreateActionResult(response);
        }
    }
}
