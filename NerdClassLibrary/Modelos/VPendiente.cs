using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class VPendiente
{
    public int IdPendiente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int IdTipoPendiente { get; set; }
}
