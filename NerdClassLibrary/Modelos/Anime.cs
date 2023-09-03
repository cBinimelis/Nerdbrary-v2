using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class Anime
{
    public int Id_Anime { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public DateTime Lanzamiento { get; set; }

    public int Temporadas { get; set; }

    public int CapitulosTotales { get; set; }

    public string? Imagen { get; set; }

    public int Id_GeneroAnime { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int Id_EstadoSerie { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<AnimeUsuario> AnimeUsuarios { get; set; } = new List<AnimeUsuario>();

    public virtual EstadoSerie Id_EstadoSerieNavigation { get; set; } = null!;

    public virtual GeneroAnime Id_GeneroAnimeNavigation { get; set; } = null!;
}
