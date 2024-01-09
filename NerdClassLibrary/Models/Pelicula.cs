using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public string Duracion { get; set; } = null!;

    public DateOnly Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdGeneroPelicula { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int IdEstadoPelicula { get; set; }

    public bool Activo { get; set; }

    public virtual EstadoPelicula IdEstadoPeliculaNavigation { get; set; } = null!;

    public virtual GeneroPelicula IdGeneroPeliculaNavigation { get; set; } = null!;

    public virtual ICollection<PeliculaUsuario> PeliculaUsuarios { get; set; } = new List<PeliculaUsuario>();
}
