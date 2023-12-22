using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class MangaUsuario
{
    public int IdMangaUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdManga { get; set; }

    public int IdAvanceManga { get; set; }

    public string Nota { get; set; } = null!;

    public virtual AvanceManga IdAvanceMangaNavigation { get; set; } = null!;

    public virtual Manga IdMangaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
