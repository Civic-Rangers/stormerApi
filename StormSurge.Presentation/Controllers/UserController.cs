using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace StormSurge.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UserController(IServiceManager service)=>
            _service = service;

        [HttpPost(Name = "CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserDTO user)
        {
            if (user == null)
                return BadRequest("User object is null");

            var createdUser = await _service.User.CreateUserAsync(user);
            return CreatedAtRoute("CreateUser", new { Id = createdUser.Id }, createdUser);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserDTO user)
        {
            if (user == null)
                return BadRequest("User object is null");

            var userToLogin = await _service.User.getUserByUsernameAndPassword(user, trackChanges: false);
            return Ok(userToLogin);
        }
    }
}
