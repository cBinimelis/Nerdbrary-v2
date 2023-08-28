using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class VManga
{
    public int IdManga { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public int Tomos { get; set; }

    public string? Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string OtrosGeneros { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
