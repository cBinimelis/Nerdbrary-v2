using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public class GeneroJuegoData : IGeneroJuegoData
{
    private readonly BdBibliotecaContext _context;

    public GeneroJuegoData(BdBibliotecaContext context)
    {
        _context = context;
    }
    public Task AddGeneroJuegoAsync(GeneroJuego generoJuego)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGeneroJuegoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GeneroJuego>> GetAllGeneroJuegoAsync()
    {
        var result = await _context.GeneroJuegos.ToListAsync();
        return result;
    }

    public Task<GeneroJuego> GetGeneroJuegoAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGeneroJuegoAsync(GeneroJuego generoJuego, int id)
    {
        throw new NotImplementedException();
    }
}
