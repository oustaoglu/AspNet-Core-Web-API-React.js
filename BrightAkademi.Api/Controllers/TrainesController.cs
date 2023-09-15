using BrightAkademiApi.Business.Abstract;
using BrightAkademiApi.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademi.Api.Controllers
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
    }
}
