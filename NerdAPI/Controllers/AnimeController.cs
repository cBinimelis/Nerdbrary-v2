using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NerdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : Controller
    {
        private readonly IAnimeData _anime;

        public AnimeController(IAnimeData anime)
        {
            _anime = anime;
        }

        // GET: api/<AnimeController>
        [HttpGet]
        public async Task<IResult> GetAnimes()
        {
            try
            {
                return Results.Ok(await _anime.GetAnimes());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // GET api/<AnimeController>/5
        [HttpGet("{id}")]
        public async Task<IResult> GetAnime(int id)
        {
            try
            {
                var results = await _anime.GetAnime(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // POST api/<AnimeController>
        [HttpPost]
        public async Task<IResult> InsertAnime(Anime anime)
        {
            try
            {
                await _anime.InsertAnime(anime);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // PUT api/<AnimeController>/5
        [HttpPut("{id}")]
        public async Task<IResult> UpdateAnime(Anime anime)
        {
            try
            {
                await _anime.UpdateAnime(anime);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // DELETE api/<AnimeController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> DeleteAnime(int id)
        {
            try
            {
                await _anime.DeleteAnime(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
