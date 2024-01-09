using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IAnimeData
    {
        Task DeleteAnimeAsync(int id);
        Task<Anime> GetAnimeAsync(int id);
        Task<List<VAnime>> GetAllAnimeAsync();
        Task AddAnimeAsync(Anime Anime);
        Task UpdateAnimeAsync(Anime Anime, int id);
    }
}