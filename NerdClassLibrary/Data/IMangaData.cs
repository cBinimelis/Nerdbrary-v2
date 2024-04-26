using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IMangaData
    {
        Task<List<VManga>> GetAllMangaAsync();
        Task<Manga> GetMangaAsync(int id);
        Task AddMangaAsync(Manga manga);
        Task UpdateMangaAsync(Manga manga, int id);
        Task DeleteMangaAsync(int id);
    }
}