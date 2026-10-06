using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LanguagesController:ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            return new string[]
            {
                "C#",
                "Java",
                "Python",
                "PHP"
            };
        }
    }
}