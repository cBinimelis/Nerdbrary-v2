using NerdClassLibrary.Modelos;

namespace NerdClassLibrary.Data
{
    public interface IMangaData
    {
        Task<IEnumerable<VManga>> GetMangas();
    }
}