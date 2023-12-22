using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class GeneroAnime
{
    public int IdGeneroAnime { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Anime> Animes { get; set; } = new List<Anime>();
}
