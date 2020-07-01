using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LandlordStudio.Recruitment.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public string Hello()
        {
            return "Hi!";
        }
    }
}
