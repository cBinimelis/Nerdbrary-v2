using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class JuegosUsuario
{
    public int IdJuegoUsuario { get; set; }

    public int IdJuego { get; set; }

    public int IdUsuario { get; set; }

    public int IdAvanceJuego { get; set; }

    public string Nota { get; set; } = null!;

    public virtual AvanceJuego IdAvanceJuegoNavigation { get; set; } = null!;

    public virtual Juego IdJuegoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
