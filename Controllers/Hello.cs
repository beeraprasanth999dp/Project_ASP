using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HelloController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello,welcome to ASP.NET core web API!";
        }
    }
}