using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class AvancePelicula
{
    public int IdAvancePelicula { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PeliculaUsuario> PeliculaUsuarios { get; set; } = new List<PeliculaUsuario>();
}
