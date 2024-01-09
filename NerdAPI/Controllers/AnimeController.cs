using Microsoft.AspNetCore.Mvc;
using NerdClassLibrary.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NerdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeData _animeData;

        public AnimeController(IAnimeData animeData)
        {
            _animeData = animeData;
        }

        [HttpGet]
        public async Task<List<VAnime>> Get()
        {
            var anime = await _animeData.GetAllAnimeAsync();
            return anime;
        }

        // GET api/<AnimeController>/5
        [HttpGet("{id}")]
        public async Task<Anime?> Get(int id)
        {
            var anime = await _animeData.GetAnimeAsync(id);
            return anime;
        }

        // POST api/<AnimeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //
        }


        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Producto producto)
        //{
        //    var result = await _productoRepository.InsertarProducto(producto);
        //    if (result > 0)
        //    {
        //        return Ok(new { message = "Producto insertado correctamente" });
        //    }
        //    else
        //    {
        //        return BadRequest(new { message = "Error al insertar el producto" });
        //    }
        //}

        // PUT api/<AnimeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Anime anime)
        {
            try
            {
                anime.IdAnime = id;
                await _animeData.UpdateAnimeAsync(anime, id);
                return Ok(new { message = "Anime actualizado correctamente" });
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = "Error al actualizar el anime" + ex.Message });
            }
        }


        // DELETE api/<AnimeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _animeData.DeleteAnimeAsync(id);
                return Ok(new { message = "Producto eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error al eliminar el producto" });
            }
        }
    }
}
