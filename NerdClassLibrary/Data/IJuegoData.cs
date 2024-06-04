using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IJuegoData
    {
        Task<List<VJuego>> GetAllJuegoAsync();

        Task<Juego> GetJuegoAsync(int id);

        Task AddJuegoAsync(Juego Juego);

        Task DeleteJuegoAsync(int id);

        Task UpdateJuegoAsync(Juego Juego, int id);
    }
}
