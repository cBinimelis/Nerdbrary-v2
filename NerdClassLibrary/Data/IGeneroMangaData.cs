using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public interface IGeneroMangaData
{
    Task<List<GeneroManga>> GetAllGeneroMangaAsync();
    Task<GeneroManga> GetGeneroMangaAsync(int id);
    Task AddGeneroMangaAsync(GeneroManga generoManga);
    Task UpdateGeneroMangaAsync(GeneroManga generoManga, int id);
    Task DeleteGeneroMangaAsync(int id);
}
