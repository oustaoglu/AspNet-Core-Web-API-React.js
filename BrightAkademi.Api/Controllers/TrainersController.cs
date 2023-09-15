using BrightAkademiApi.Business.Abstract;
using BrightAkademiApi.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademi.Api.Controllers
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
    }
}
