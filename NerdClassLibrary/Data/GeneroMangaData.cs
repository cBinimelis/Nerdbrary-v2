using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public class GeneroMangaData : IGeneroMangaData
    {
        private readonly BdBibliotecaContext _context;

        public GeneroMangaData(BdBibliotecaContext context)
        {
            _context = context;
        }

        public Task AddGeneroMangaAsync(GeneroManga generoManga)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGeneroMangaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GeneroManga>> GetAllGeneroMangaAsync()
        {
            var result = await _context.GeneroMangas.ToListAsync();
            return result;
        }

        public Task<GeneroManga> GetGeneroMangaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGeneroMangaAsync(GeneroManga generoManga, int id)
        {
            throw new NotImplementedException();
        }
    }
}
