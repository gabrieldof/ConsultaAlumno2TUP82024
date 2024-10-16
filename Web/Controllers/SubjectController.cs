using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {


        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet("subjects")]

        public IActionResult Get()
        {
            return Ok(_subjectService.GetAll());
        }

        [HttpGet("subjects/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_subjectService.GetById(id));
        }

        //[HttpPost]
        //public IActionResult Add([FromBody] UserForAddRequest userForAdd)
        //{
        //    return Ok(_userService.Add(userForAdd));
        //}

        //[HttpPut("{id}")]
        //public IActionResult Update(int id, [FromBody] UserForUpdateRequest userForUpdate)
        //{
        //    return Ok(_userService.Update(id, userForUpdate));
        //}
    }
}
