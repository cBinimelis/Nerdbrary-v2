using Microsoft.EntityFrameworkCore;
using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public class JuegoData : IJuegoData
    {
        private readonly BdBibliotecaContext _dbContext;

        public JuegoData(BdBibliotecaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddJuegoAsync(Juego Juego)
        {
            _dbContext.Juegos.Add(Juego);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteJuegoAsync(int id)
        {
            var juego = await _dbContext.Juegos.FirstOrDefaultAsync(j => j.IdJuego == id);
            if (juego != null)
            {
                _dbContext.Remove(juego);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<VJuego>> GetAllJuegoAsync()
        {
            var juegos = await _dbContext.VJuegos.ToListAsync();
            return juegos;
        }

        public async Task<Juego> GetJuegoAsync(int id)
        {
            var juego = await _dbContext.Juegos.FindAsync(id);
            return juego;
        }

        public async Task UpdateJuegoAsync(Juego Juego, int id)
        {
            var juego = await _dbContext.Juegos.FindAsync(id);
            if (juego != null)
            {
                juego.Nombre = Juego.Nombre;
                juego.Sinopsis = Juego.Sinopsis;
                juego.IdDesarrollador = Juego.IdDesarrollador;
                juego.Lanzamiento = Juego.Lanzamiento;
                juego.Imagen = Juego.Imagen;
                juego.IdGeneroJuego = Juego.IdGeneroJuego;
                juego.OtrosGeneros = Juego.OtrosGeneros;
                juego.IdEstadoJuego = Juego.IdEstadoJuego;
                juego.Activo = Juego.Activo;

                _dbContext.Update(juego);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
