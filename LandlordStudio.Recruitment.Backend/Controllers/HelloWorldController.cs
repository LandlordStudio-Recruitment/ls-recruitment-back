using Microsoft.AspNetCore.Mvc;

namespace LandlordStudio.Recruitment.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string SayHello()
        {
            return "Hello from the Landlord Studio recruitment test backend";
        }
    }
}
