using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SquareController: ControllerBase
    {
        [HttpPost]
        public int Get(Number number)
        {
            return number.value*number.value;
        }
    }
    public class Number
    {
        public int value{get;set;}
    }
}