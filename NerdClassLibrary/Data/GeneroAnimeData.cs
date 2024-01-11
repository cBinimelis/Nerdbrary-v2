using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class GeneroAnimeData : IGeneroAnimeData
    {
        private readonly BdBibliotecaContext _context;

        public GeneroAnimeData(BdBibliotecaContext context)
        {
            _context = context;
        }
        public Task AddGeneroAnimeAsync(GeneroAnime generoAnime)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGeneroAnimeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GeneroAnime>> GetAllGeneroAnimeAsync()
        {
            var result = await _context.GeneroAnimes.ToListAsync();
            return result;
        }

        public Task<GeneroAnime> GetGeneroAnimeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGeneroAnimeAsync(GeneroAnime generoAnime, int id)
        {
            throw new NotImplementedException();
        }
    }
}
