using BrightAkademiApi.Business.Abstract;
using BrightAkademiApi.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademi.Api.Controllers
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
    }
}
