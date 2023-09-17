using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
