using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers{

    [ApiController]
    [Route("[Controller]")]
    
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
       public object post(int id)
        {
            if (id == 101)
            {
            return new
            {
                id=101,
                Name="rahul",
                Department="IT"

            };
        }
        return "Employee Not found";
        }
    }
}