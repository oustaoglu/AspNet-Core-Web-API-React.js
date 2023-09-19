using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
