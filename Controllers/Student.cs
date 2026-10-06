using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StudentControler:ControllerBase
    {
        [HttpGet]
        public Student Get()
        {
    
    Student obj=new Student();
    obj.id=101;
    obj.name="prasanth";
    obj.course="B.tech";
    obj.age=21;
    return obj;
    }
}
public class Student
    {
          public int id { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public int age { get; set; }
        
    }

}   
