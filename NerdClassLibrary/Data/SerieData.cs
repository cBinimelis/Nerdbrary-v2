using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public class SerieData : ISerieData
{
    private readonly BdBibliotecaContext _context;

    public SerieData(BdBibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<VSeries>> GetAllSerieAsync()
    {
        var result = await _context.VSeries.OrderBy(x => x.Nombre).ToListAsync();
        return result;
    }

    public async Task<Series> GetSerieAsync(int id)
    {
        var result = await _context.Series.FindAsync(id);
        return result;
    }

    public async Task AddSerieAsync(Series Serie)
    {
        _context.Series.Add(Serie);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSerieAsync(int id)
    {
        var Serie = await _context.Series.FindAsync(id);
        if (Serie != null)
        {
            _context.Remove(Serie);
            await _context.SaveChangesAsync();
        }
    }

    public async Task UpdateSerieAsync(Series Serie, int id)
    {
        var dbSerie = await _context.Series.FindAsync(id);
        if (dbSerie != null)
        {
            dbSerie.Nombre = Serie.Nombre;
            dbSerie.Sinopsis = Serie.Sinopsis;
            dbSerie.Lanzamiento = Serie.Lanzamiento;
            dbSerie.Temporadas = Serie.Temporadas;
            dbSerie.CapitulosTotales = Serie.CapitulosTotales;
            dbSerie.Imagen = Serie.Imagen;
            dbSerie.IdGeneroSerie = Serie.IdGeneroSerie;
            dbSerie.OtrosGeneros = Serie.OtrosGeneros;
            dbSerie.IdEstadoSerie = Serie.IdEstadoSerie;
            dbSerie.Activo = Serie.Activo;

            _context.Update(dbSerie);
            await _context.SaveChangesAsync();
        }
    }
}