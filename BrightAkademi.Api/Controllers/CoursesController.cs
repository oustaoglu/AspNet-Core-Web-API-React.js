using BrightAkademiApi.Business.Abstract;
using BrightAkademiApi.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomControllerBase
    {
        private readonly ICourseService _courseManager;

        public CoursesController(ICourseService courseManager)
        {
            _courseManager = courseManager;
        }
    }
}
