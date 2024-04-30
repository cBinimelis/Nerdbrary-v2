using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public interface IPeliculaData
{
    Task<List<VPelicula>> GetAllPeliculaAsync();
    Task<Pelicula> GetPeliculaAsync(int id);
    Task AddPeliculaAsync(Pelicula Pelicula);
    Task DeletePeliculaAsync(int id);
    Task UpdatePeliculaAsync(Pelicula Pelicula, int id);
}