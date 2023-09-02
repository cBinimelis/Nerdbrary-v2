using NerdClassLibrary.DbAccess;
using NerdClassLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class UsuarioData
    {
        private readonly ISqlDataAccess _db;
public UsuarioData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Usuario>> GetUsuarios() =>
            _db.LoadData<Usuario, dynamic>(storedProcedure: "GetUsuarios", new { });

        public async Task<Usuario?> GetUsuario(int id)
        {
            var result = await _db.LoadData<Usuario, dynamic>(
                storedProcedure: "GetUsuario", new { Id = id });

            return result.FirstOrDefault();
        }
    }
}
