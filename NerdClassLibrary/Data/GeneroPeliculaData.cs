using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data;

public class GeneroPeliculaData : IGeneroPeliculaData
{
    BdBibliotecaContext _context = new BdBibliotecaContext();

    public GeneroPeliculaData(BdBibliotecaContext context)
    {
        _context = context;
    }

    public Task AddGeneroPeliculaAsync(GeneroPelicula generoPelicula)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGeneroPeliculaAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GeneroPelicula>> GetAllGeneroPeliculaAsync()
    {
        var result = await _context.GeneroPeliculas.ToListAsync();
        return result;
    }

    public Task<GeneroPelicula> GetGeneroPeliculaAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGeneroPeliculaAsync(GeneroPelicula generoPelicula, int id)
    {
        throw new NotImplementedException();
    }
}
