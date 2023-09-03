using NerdClassLibrary.DbAccess;
using NerdClassLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class AnimeData : IAnimeData
    {
        private readonly ISqlDataAccess _db;
        public AnimeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<VAnime>> GetAnimes() =>
            _db.LoadData<VAnime, dynamic>(storedProcedure: "Animes_Get", new { });

        public async Task<VAnime?> GetAnime(int id)
        {
            var result = await _db.LoadData<VAnime, dynamic>(
                storedProcedure: "Anime_Get", new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertAnime(Anime Anime) =>
            _db.SaveData(storedProcedure: "Anime_Create", new
            {
                Anime.Nombre,
                Anime.Sinopsis,
                Anime.Lanzamiento,
                Anime.Temporadas,
                Anime.CapitulosTotales,
                Anime.Imagen,
                Anime.Id_GeneroAnime,
                Anime.OtrosGeneros,
                Anime.Id_EstadoSerie,
                Anime.Activo
            });

        public Task UpdateAnime(Anime Anime) =>
            _db.SaveData(storedProcedure: "Anime_Update", Anime);

        public Task DeleteAnime(int id) =>
            _db.SaveData(storedProcedure: "Anime_Delete", new { Id = id });

    }
}
