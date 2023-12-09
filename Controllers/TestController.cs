using Microsoft.AspNetCore.Mvc;

namespace pokeapi.Controllers;
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }
        
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Hello world");
        }
    }