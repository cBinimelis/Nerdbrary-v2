using NerdClassLibrary.Modelos;

namespace NerdClassLibrary.Data
{
    public interface IUsuarioData
    {
        Task DeleteUsuario(int id);
        Task<Usuario?> GetUsuario(int id);
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task InsertUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
    }
}