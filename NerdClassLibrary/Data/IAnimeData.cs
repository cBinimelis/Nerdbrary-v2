using NerdClassLibrary.Modelos;

namespace NerdClassLibrary.Data
{
    public interface IAnimeData
    {
        Task DeleteAnime(int id);
        Task<VAnime?> GetAnime(int id);
        Task<IEnumerable<VAnime>> GetAnimes();
        Task InsertAnime(Anime Anime);
        Task UpdateAnime(Anime Anime);
    }
}