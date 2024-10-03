using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("users")]

        public IActionResult Get()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("users/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserForAddRequest userForAdd)
        {
            return Ok(_userService.Add(userForAdd));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UserForUpdateRequest userForUpdate)
        {
            return Ok(_userService.Update(id, userForUpdate));
        }



    }
}
