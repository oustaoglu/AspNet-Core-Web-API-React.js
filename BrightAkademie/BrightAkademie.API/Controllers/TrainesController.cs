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
        private readonly ITraineeService traineeManager;

        public TrainesController(ITraineeService traineeManager)
        {
            this.traineeManager = traineeManager;
        }
    }
}
