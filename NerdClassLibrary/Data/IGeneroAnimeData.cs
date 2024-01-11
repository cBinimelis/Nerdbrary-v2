using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IGeneroAnimeData
    {
        Task<List<GeneroAnime>> GetAllGeneroAnimeAsync();
        Task<GeneroAnime> GetGeneroAnimeAsync(int id);
        Task AddGeneroAnimeAsync(GeneroAnime generoAnime);
        Task UpdateGeneroAnimeAsync(GeneroAnime generoAnime, int id);
        Task DeleteGeneroAnimeAsync(int id);
    }
}
