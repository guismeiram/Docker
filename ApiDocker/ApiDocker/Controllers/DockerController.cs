using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DockerController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("hellow world");
        }
    }
}
