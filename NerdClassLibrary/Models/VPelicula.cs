using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class VPelicula
{
    public int IdPelicula { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public string Duracion { get; set; } = null!;

    public string? Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string OtrosGeneros { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
