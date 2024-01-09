using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class Anime
{
    public int IdAnime { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public DateOnly Lanzamiento { get; set; }

    public int Temporadas { get; set; }

    public int CapitulosTotales { get; set; }

    public string? Imagen { get; set; }

    public int IdGeneroAnime { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int IdEstadoSerie { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<AnimeUsuario> AnimeUsuarios { get; set; } = new List<AnimeUsuario>();

    public virtual EstadoSerie IdEstadoSerieNavigation { get; set; } = null!;

    public virtual GeneroAnime IdGeneroAnimeNavigation { get; set; } = null!;
}
