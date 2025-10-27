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
            await Task.Delay(10); // Simulate some async work
            return Ok("Hello, World!");
        }
    }
}
