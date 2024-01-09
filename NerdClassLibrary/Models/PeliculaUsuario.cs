using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class PeliculaUsuario
{
    public int IdPeliculaUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdPelicula { get; set; }

    public int IdAvancePelicula { get; set; }

    public string Nota { get; set; } = null!;

    public virtual AvancePelicula IdAvancePeliculaNavigation { get; set; } = null!;

    public virtual Pelicula IdPeliculaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
