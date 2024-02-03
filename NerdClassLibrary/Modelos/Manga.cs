using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NerdClassLibrary.Modelos;

public partial class Manga
{
    public int IdManga { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public DateTime Lanzamiento { get; set; }

    public int Tomos { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdGeneroManga { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int IdEstadoManga { get; set; }

    public bool? Activo { get; set; }

    public virtual EstadoManga IdEstadoMangaNavigation { get; set; } = null!;

    public virtual GeneroManga IdGeneroMangaNavigation { get; set; } = null!;

    public virtual ICollection<MangaUsuario> MangaUsuarios { get; set; } = new List<MangaUsuario>();
}
