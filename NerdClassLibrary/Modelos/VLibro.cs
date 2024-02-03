using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class VLibro
{
    public int IdLibro { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public int Paginas { get; set; }

    public int IdAutor { get; set; }

    public string Autor { get; set; } = null!;

    public string? Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string? OtrosGeneros { get; set; }

    public string Estado { get; set; } = null!;
}
