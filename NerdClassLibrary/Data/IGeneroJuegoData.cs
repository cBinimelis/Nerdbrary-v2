using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data;

public interface IGeneroJuegoData
{
    Task<List<GeneroJuego>> GetAllGeneroJuegoAsync();
    Task<GeneroJuego> GetGeneroJuegoAsync(int id);
    Task AddGeneroJuegoAsync(GeneroJuego generoJuego);
    Task UpdateGeneroJuegoAsync(GeneroJuego generoJuego, int id);
    Task DeleteGeneroJuegoAsync(int id);
}
