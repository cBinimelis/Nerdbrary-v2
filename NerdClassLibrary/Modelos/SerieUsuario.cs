using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class SerieUsuario
{
    public int IdSerieUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdSerie { get; set; }

    public int IdAvanceSerie { get; set; }

    public string Nota { get; set; } = null!;

    public virtual AvanceSerie IdAvanceSerieNavigation { get; set; } = null!;

    public virtual Series IdSerieNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
