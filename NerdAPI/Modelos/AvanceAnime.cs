using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class AvanceAnime
{
    public int IdAvanceAnime { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<AnimeUsuario> AnimeUsuarios { get; set; } = new List<AnimeUsuario>();
}
