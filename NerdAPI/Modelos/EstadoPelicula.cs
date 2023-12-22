using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class EstadoPelicula
{
    public int IdEstadoPelicula { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
