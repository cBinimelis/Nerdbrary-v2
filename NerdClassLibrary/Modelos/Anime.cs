using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NerdClassLibrary.Modelos;

public partial class Anime
{
    public int Id_Anime { get; set; }

    [Required(ErrorMessage = "Que tonto. No puedes ingresar un Anime sin un nombre.")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "Vaya sonso. La sinopsis es necesaria para ingresar un anime.")]
    public string Sinopsis { get; set; } = null!;

    [Required(ErrorMessage = "Si no te la sabes, al menos date el trabajo de inventar algo")]
    public DateTime Lanzamiento { get; set; }

    public int Temporadas { get; set; }

    [Required(ErrorMessage = "Googlear no cuesta tanto, hágale")]
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
