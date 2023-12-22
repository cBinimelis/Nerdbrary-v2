using NerdClassLibrary.DbAccess;
using NerdClassLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdClassLibrary.Data
{
    public class MangaData : IMangaData
    {
        private readonly ISqlDataAccess _db;
        public MangaData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<VManga>> GetMangas() =>
            _db.LoadData<VManga, dynamic>(storedProcedure: "Mangas_Get", new { });

        public async Task<VManga?> GetManga(int id)
        {
            var result = await _db.LoadData<VManga, dynamic>(
                storedProcedure: "Manga_Get", new { Id = id });

            return result.FirstOrDefault();
        }

        //TODO - Insert Manga

        public Task UpdateManga(Manga Manga) =>
            _db.SaveData(storedProcedure: "Manga_Update", Manga);
    }
}
