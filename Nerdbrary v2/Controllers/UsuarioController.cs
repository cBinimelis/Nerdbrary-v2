using NerdClassLibrary.Models;

namespace Nerdbrary_v2.Controllers
{
    public class UsuarioController
    {
        public static async Task<IResult> GetUsuarios(IUsuarioData ud)
        {
            try
            {
                return Results.Ok(await ud.GetUsuarios());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetUsuario(int id, IUsuarioData ud)
        {
            try
            {
                var results = await ud.GetUsuario(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> InsertUsuario(Usuario usuario, IUsuarioData ud)
        {
            try
            {
                await ud.InsertUsuario(usuario);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateUsuario(Usuario usuario, IUsuarioData ud)
        {
            try
            {
                await ud.UpdateUsuario(usuario);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        public static async Task<IResult> DeleteUsuario(int id, IUsuarioData ud)
        {
            try
            {
                await ud.DeleteUsuario(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
