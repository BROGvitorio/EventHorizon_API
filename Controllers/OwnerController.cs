using EventHorizon_API.Data;
using EventHorizon_API.Models.Owners;
using Microsoft.AspNetCore.Mvc;


namespace EventHorizon_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public OwnerController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("AddOwner")]
        public async Task<IActionResult> AddOwner(Owner newOwner)
        {
            _appDbContext.Owners.Add(newOwner);
            await _appDbContext.SaveChangesAsync();

            return Created();
        }
    }
}
