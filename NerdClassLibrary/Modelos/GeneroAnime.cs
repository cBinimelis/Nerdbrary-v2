using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class GeneroAnime
{
    public int IdGeneroAnime { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Anime> Animes { get; set; } = new List<Anime>();
}
