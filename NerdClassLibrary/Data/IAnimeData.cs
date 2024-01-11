using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IAnimeData
    {
        Task<List<VAnime>> GetAllAnimeAsync();
        Task<Anime> GetAnimeAsync(int id);
        Task AddAnimeAsync(Anime Anime);
        Task UpdateAnimeAsync(Anime Anime, int id);
        Task DeleteAnimeAsync(int id);
    }
}