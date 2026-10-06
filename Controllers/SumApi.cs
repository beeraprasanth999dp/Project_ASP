using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
   [ApiController]
   [Route("[Controller]")]
   public class SumApiController:ControllerBase
    {
        [HttpPost]
      public int post(int num1, int num2)
        {
            return num1+num2;
        }

    } 

}
