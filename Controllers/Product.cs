using Microsoft.AspNetCore.Mvc;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public Products Get()
        {
            Products obj=new Products();
            obj.Name="Laptop";
            obj.Price=200000;
            obj.Id=2;
            return obj;
        }
    }
    public class Products
    {
        public string Name{get;set;}
        public int Price{get;set;}
        public int Id {get;set;}
    }
}