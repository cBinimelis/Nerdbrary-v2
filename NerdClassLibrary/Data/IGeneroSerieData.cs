using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IGeneroSerieData
    {
        Task<List<GeneroSerie>> GetAllGeneroSerieAsync();
        Task<GeneroSerie> GetGeneroSerieAsync(int id);
        Task AddGeneroSerieAsync(GeneroSerie generoSerie);
        Task UpdateGeneroSerieAsync(GeneroSerie generoSerie, int id);
        Task DeleteGeneroSerieAsync(int id);
    }
}
