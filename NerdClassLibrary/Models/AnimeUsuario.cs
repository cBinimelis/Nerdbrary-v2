using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class AnimeUsuario
{
    public long IdAnimeUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdAnime { get; set; }

    public int IdAvanceAnime { get; set; }

    public string? Nota { get; set; }

    public virtual Anime IdAnimeNavigation { get; set; } = null!;

    public virtual AvanceAnime IdAvanceAnimeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
