using DigiVisio2030.BL.Models;
using DigiVisio2030.BL.Users;
using Microsoft.AspNetCore.Mvc;

namespace DigiVisio2030.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await _usersService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("withCities")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsersWithCities()
        {
            var users = await _usersService.GetAllUsersWithCities();
            return Ok(users);
        }
    }
}
