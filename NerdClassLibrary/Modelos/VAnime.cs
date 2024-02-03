using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class VAnime
{
    public int Id_Anime { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public string? Lanzamiento { get; set; }

    public int Temporadas { get; set; }

    public int Capitulos { get; set; }

    public string? Imagen { get; set; }

    public string Genero { get; set; } = null!;

    public string OtrosGeneros { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
