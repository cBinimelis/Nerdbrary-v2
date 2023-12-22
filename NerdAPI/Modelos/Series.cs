using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class Series
{
    public int IdSerie { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public DateOnly Lanzamiento { get; set; }

    public int Temporadas { get; set; }

    public int CapitulosTotales { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdGeneroSerie { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int IdEstadoSerie { get; set; }

    public int IdUsuario { get; set; }

    public bool Activo { get; set; }

    public virtual EstadoSerie IdEstadoSerieNavigation { get; set; } = null!;

    public virtual GeneroSerie IdGeneroSerieNavigation { get; set; } = null!;

    public virtual ICollection<SerieUsuario> SerieUsuarios { get; set; } = new List<SerieUsuario>();
}
