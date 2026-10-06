using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CreateStudent:ControllerBase
    {
        [HttpPost]
        public object  post(CStudent student)
        {
            return new
            {
                Name=student.Name,
                age=student.age,
                section=student.section
            };
        }
    }
    public class CStudent{
        public string Name;
        public int age;
        public string section;
            
        }
}