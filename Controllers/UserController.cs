using EventHorizon_API.Data;
using EventHorizon_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventHorizon_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UserController (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User newUser)
        {
            _appDbContext.Users.Add(newUser);
            await _appDbContext.SaveChangesAsync();

            return Ok(newUser);
        }
    }
}
