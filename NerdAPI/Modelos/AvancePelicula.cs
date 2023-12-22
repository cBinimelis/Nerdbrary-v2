using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class AvancePelicula
{
    public int IdAvancePelicula { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PeliculaUsuario> PeliculaUsuarios { get; set; } = new List<PeliculaUsuario>();
}
