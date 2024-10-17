using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ICustomAuthenticationService _customAuthenticationService;
        public AuthenticateController(IUserService userService, ICustomAuthenticationService authenticationService)
        {
            _userService = userService;
            _customAuthenticationService = authenticationService;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthenticationRequest credentials)
        {
            string token = _customAuthenticationService.Authenticate(credentials);
            return Ok(token);
        }

    }
}
