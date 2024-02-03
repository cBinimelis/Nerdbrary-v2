using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class GeneroManga
{
    public int IdGeneroManga { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Manga> Mangas { get; set; } = new List<Manga>();
}
