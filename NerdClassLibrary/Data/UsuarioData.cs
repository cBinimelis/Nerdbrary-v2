using NerdClassLibrary.DbAccess;
using NerdClassLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class UsuarioData : IUsuarioData
    {
        private readonly ISqlDataAccess _db;
        public UsuarioData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Usuario>> GetUsuarios() =>
            _db.LoadData<Usuario, dynamic>(storedProcedure: "Usuarios_Get", new { });

        public async Task<Usuario?> GetUsuario(int id)
        {
            var result = await _db.LoadData<Usuario, dynamic>(
                storedProcedure: "Usuario_Get", new { Id = id });

            return result.FirstOrDefault();
        }

        public Task InsertUsuario(Usuario usuario) =>
            _db.SaveData(storedProcedure: "Usuario_Create", new
            { usuario.Nick, usuario.Password, usuario.IdEstadoUsuario, usuario.IdTipoUsuario, usuario.Imagen, usuario.Fondo });

        public Task UpdateUsuario(Usuario usuario) =>
            _db.SaveData(storedProcedure: "Usuario_Update", usuario);

        public Task DeleteUsuario(int id) =>
            _db.SaveData(storedProcedure: "Usuario_Delete", new { Id = id });
    }
}
