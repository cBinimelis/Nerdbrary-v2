using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class Pendiente
{
    public int IdPendiente { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int IdTipoPendiente { get; set; }

    public virtual TipoPendiente IdTipoPendienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
