using Microsoft.AspNetCore.Mvc;

namespace CICD_Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello, World!");
        }
    }
}
