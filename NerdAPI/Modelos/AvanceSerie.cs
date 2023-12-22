using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class AvanceSerie
{
    public int IdAvanceSerie { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SerieUsuario> SerieUsuarios { get; set; } = new List<SerieUsuario>();
}
