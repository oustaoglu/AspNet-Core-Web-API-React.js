using BrightAkademie.Business.Abstract;
using BrightAkademie.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrightAkademie.API.Controllers
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
