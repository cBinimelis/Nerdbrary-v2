using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class GeneroSerie
{
    public int IdGeneroSerie { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Series> Series { get; set; } = new List<Series>();
}
