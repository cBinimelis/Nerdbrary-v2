using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;
public class GeneroSerieData : IGeneroSerieData
{
    BdBibliotecaContext _context = new();

    public GeneroSerieData(BdBibliotecaContext context){
        _context = context;
    }
    public Task AddGeneroSerieAsync(GeneroSerie generoSerie)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGeneroSerieAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GeneroSerie>> GetAllGeneroSerieAsync()
    {
        var result =  await _context.GeneroSeries.ToListAsync();
        return result;
    }

    public Task<GeneroSerie> GetGeneroSerieAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGeneroSerieAsync(GeneroSerie generoSerie, int id)
    {
        throw new NotImplementedException();
    }
}