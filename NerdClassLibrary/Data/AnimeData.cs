using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.DbAccess;
using NerdClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class AnimeData : IAnimeData
    {
        private readonly BdBibliotecaContext _context;

        public AnimeData(BdBibliotecaContext context)
        {
            _context = context;
        }

        public async Task<List<VAnime>> GetAllAnimeAsync()
        {
            var result = await _context.VAnimes.ToListAsync();
            return result;
        }

        public async Task<Anime> GetAnimeAsync(int id)
        {
            var result = await _context.Animes.FindAsync(id);
            return result;
        }

        public async Task AddAnimeAsync(Anime anime)
        {
            _context.Animes.Add(anime);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnimeAsync(int id)
        {
            var anime = await _context.Animes.FindAsync(id);
            if(anime != null)
            {
                _context.Remove(anime);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAnimeAsync(Anime anime, int id)
        {
            var dbAnime = await _context.Animes.FindAsync(id);
            if(dbAnime != null)
            {
                dbAnime.Nombre = anime.Nombre;
                dbAnime.Sinopsis = anime.Sinopsis;
                dbAnime.Lanzamiento = anime.Lanzamiento;
                dbAnime.Temporadas = anime.Temporadas;
                dbAnime.CapitulosTotales = anime.CapitulosTotales;
                dbAnime.Imagen = anime.Imagen;
                dbAnime.IdGeneroAnime = anime.IdGeneroAnime;
                dbAnime.OtrosGeneros = anime.OtrosGeneros;
                dbAnime.IdEstadoSerie = anime.IdEstadoSerie;
                dbAnime.Activo = anime.Activo;

                _context.Update(dbAnime);
                await _context.SaveChangesAsync();
            }
        }

        //DAPPER - DEPRECATED FOR THIS PROJECT
        /*
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
                Anime.IdGeneroAnime,
                Anime.OtrosGeneros,
                Anime.IdEstadoSerie,
                Anime.Activo
            });

        public Task UpdateAnime(Anime Anime) =>
            _db.SaveData(storedProcedure: "Anime_Update", Anime);

        public Task DeleteAnime(int id) =>
            _db.SaveData(storedProcedure: "Anime_Delete", new { Id = id });

        */
    }
}
