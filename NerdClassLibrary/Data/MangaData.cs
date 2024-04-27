using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public class MangaData : IMangaData
    {
        private readonly BdBibliotecaContext _context;

        public MangaData(BdBibliotecaContext context)
        {
            _context = context;
        }

        public async Task<List<VManga>> GetAllMangaAsync()
        {
            var result = await _context.VMangas.ToListAsync();
            return result;
        }

        public async Task<Manga> GetMangaAsync(int id)
        {
            var result = await _context.Mangas.FindAsync(id);
            return result;
        }

        public async Task AddMangaAsync(Manga manga)
        {
            _context.Mangas.Add(manga);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMangaAsync(int id)
        {
            var manga = await _context.Mangas.FindAsync(id);
            if (manga != null)
            {
                _context.Remove(manga);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateMangaAsync(Manga manga, int id)
        {
            var dbManga = await _context.Mangas.FindAsync(id);
            if (dbManga != null)
            {
                dbManga.Nombre = manga.Nombre;
                dbManga.Sinopsis = manga.Sinopsis;
                dbManga.Lanzamiento = manga.Lanzamiento;
                dbManga.Tomos = manga.Tomos;
                dbManga.Imagen = manga.Imagen;
                dbManga.IdGeneroManga = manga.IdGeneroManga;
                dbManga.OtrosGeneros = manga.OtrosGeneros;
                dbManga.IdEstadoManga = manga.IdEstadoManga;
                dbManga.Activo = manga.Activo;

                _context.Update(dbManga);
                await _context.SaveChangesAsync();
            }
        }
    }
}
