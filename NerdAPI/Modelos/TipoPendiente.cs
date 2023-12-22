using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class TipoPendiente
{
    public int IdTipoPendiente { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Pendiente> Pendientes { get; set; } = new List<Pendiente>();
}
