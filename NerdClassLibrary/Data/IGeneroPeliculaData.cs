using NerdClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public interface IGeneroPeliculaData
    {
        Task<List<GeneroPelicula>> GetAllGeneroPeliculaAsync();
        Task<GeneroPelicula> GetGeneroPeliculaAsync(int id);
        Task AddGeneroPeliculaAsync(GeneroPelicula generoPelicula);
        Task UpdateGeneroPeliculaAsync(GeneroPelicula generoPelicula, int id);
        Task DeleteGeneroPeliculaAsync(int id);
    }
}
