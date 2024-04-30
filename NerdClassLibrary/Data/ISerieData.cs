using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;
public interface ISerieData{
    Task<List<VSeries>> GetAllSerieAsync();
    Task<Series> GetSerieAsync(int id);
    Task AddSerieAsync(Series Serie);
    Task UpdateSerieAsync(Series Serie, int id);
    Task DeleteSerieAsync(int id);
}