using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class EstadoManga
{
    public int IdEstadoManga { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Manga> Mangas { get; set; } = new List<Manga>();
}
