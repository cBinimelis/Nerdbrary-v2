using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NerdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly NerdContext _context;
        public AnimeController(NerdContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimes()
        {
            return Ok(await _context.Animes.ToListAsync());
        }
    }
}
