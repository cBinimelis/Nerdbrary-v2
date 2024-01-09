using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class AvanceManga
{
    public int IdAvanceManga { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<MangaUsuario> MangaUsuarios { get; set; } = new List<MangaUsuario>();
}
