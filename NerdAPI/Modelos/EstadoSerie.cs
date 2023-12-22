using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class EstadoSerie
{
    public int IdEstadoSerie { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Anime> Animes { get; set; } = new List<Anime>();

    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}
