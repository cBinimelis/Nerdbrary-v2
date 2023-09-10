using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NerdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioData _usuario;

        public UsuarioController(IUsuarioData usuario)
        {
            _usuario = usuario;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IResult> GetUsuarios()
        {
            try
            {
                return Results.Ok(await _usuario.GetUsuarios());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<IResult> GetUsuario(int id)
        {
            try
            {
                var results = await _usuario.GetUsuario(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<IResult> InsertUsuario(Usuario usuario)
        {
            try
            {
                await _usuario.InsertUsuario(usuario);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IResult> UpdateUsuario(Usuario usuario)
        {
            try
            {
                await _usuario.UpdateUsuario(usuario);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> DeleteUsuario(int id)
        {
            try
            {
                await _usuario.DeleteUsuario(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
