using NerdClassLibrary.Models;

namespace NerdClassLibrary.Data
{
    public interface IMangaData
    {
        Task<IEnumerable<VManga>> GetMangas();
    }
}