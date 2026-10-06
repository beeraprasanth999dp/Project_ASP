using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    
    public class ParameterController:ControllerBase
    {
        [HttpPost("{name}")]
        public string Get(string name)
        {
            return "Hello"+name+"!";
        }

    }
}