using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public class PeliculaData : IPeliculaData
{
    private readonly BdBibliotecaContext _context;

    public PeliculaData(BdBibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<VPelicula>> GetAllPeliculaAsync()
    {
        var result = await _context.VPeliculas.OrderBy(x => x.Nombre).ToListAsync();
        return result;
    }

    public async Task<Pelicula> GetPeliculaAsync(int id)
    {
        var result = await _context.Peliculas.FindAsync(id);
        return result;
    }

    public async Task AddPeliculaAsync(Pelicula Pelicula)
    {
        _context.Peliculas.Add(Pelicula);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePeliculaAsync(int id)
    {
        var Pelicula = await _context.Peliculas.FindAsync(id);
        if (Pelicula != null)
        {
            _context.Remove(Pelicula);
            await _context.SaveChangesAsync();
        }
    }

    public async Task UpdatePeliculaAsync(Pelicula Pelicula, int id)
    {
        var dbPelicula = await _context.Peliculas.FindAsync(id);
        if (dbPelicula != null)
        {
            dbPelicula.Nombre = Pelicula.Nombre;
            dbPelicula.Sinopsis = Pelicula.Sinopsis;
            dbPelicula.Duracion = Pelicula.Duracion;
            dbPelicula.Lanzamiento = Pelicula.Lanzamiento;
            dbPelicula.Imagen = Pelicula.Imagen;
            dbPelicula.IdGeneroPelicula = Pelicula.IdGeneroPelicula;
            dbPelicula.OtrosGeneros = Pelicula.OtrosGeneros;
            dbPelicula.IdEstadoPelicula = Pelicula.IdEstadoPelicula;
            dbPelicula.Activo = Pelicula.Activo;

            _context.Update(dbPelicula);
            await _context.SaveChangesAsync();
        }
    }
}