using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]

        public JsonResult Get()
        {
            return new JsonResult(new List<User> {
                                        new User { Id=1, Name= "Gabriel", LastName="Furrer", Password="1234", Email="hola@gmail.com" },
                                        new User { Id=2, Name= "Carlos", LastName="Perez", Password="1234", Email="hola@gmail.com" },
                                         new User { Id=3, Name= "Pedro", LastName="Rodriguez", Password="1234", Email="hola@gmail.com" }
            });
        }

    }
}
