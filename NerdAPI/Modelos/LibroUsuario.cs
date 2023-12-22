using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class LibroUsuario
{
    public int IdLibroUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdLibro { get; set; }

    public int IdAvanceLibro { get; set; }

    public string Nota { get; set; } = null!;

    public virtual AvanceLibro IdAvanceLibroNavigation { get; set; } = null!;

    public virtual Libro IdLibroNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
