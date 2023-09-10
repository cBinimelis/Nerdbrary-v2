namespace NerdMinimalAPI
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/Anime", GetAnimes);
            app.MapGet("/Anime/{id}", GetAnime);
            app.MapPost("/Anime", InsertAnime);
            app.MapPut("/Anime", UpdateAnime);
            app.MapDelete("/Anime", DeleteAnime);

            app.MapGet("/Usuarios", GetUsuarios);
            app.MapGet("/Usuarios/{id}", GetUsuario);
            app.MapPost("/Usuarios", InsertUsuario);
            app.MapPut("/Usuarios", UpdateUsuario);
            app.MapDelete("/Usuarios", DeleteUsuario);
        }


        //------------------------------------------------------------------------------------ANIME
        private static async Task<IResult> GetAnimes(IAnimeData data)
        {
            try
            {
                return Results.Ok(await data.GetAnimes());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetAnime(int id, IAnimeData data)
        {
            try
            {
                var results = await data.GetAnime(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertAnime(Anime anime, IAnimeData data)
        {
            try
            {
                await data.InsertAnime(anime);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateAnime(Anime anime, IAnimeData data)
        {
            try
            {
                await data.UpdateAnime(anime);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteAnime(int id, IAnimeData data)
        {
            try
            {
                await data.DeleteAnime(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        //------------------------------------------------------------------------------------USUARIOS
        private static async Task<IResult> GetUsuarios(IUsuarioData ud)
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

        private static async Task<IResult> GetUsuario(int id, IUsuarioData ud)
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

        private static async Task<IResult> InsertUsuario(Usuario usuario, IUsuarioData ud)
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

        private static async Task<IResult> UpdateUsuario(Usuario usuario, IUsuarioData ud)
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

        private static async Task<IResult> DeleteUsuario(int id, IUsuarioData ud)
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