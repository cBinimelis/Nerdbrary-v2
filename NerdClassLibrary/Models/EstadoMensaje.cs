using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class EstadoMensaje
{
    public int IdEstadoMensaje { get; set; }

    public string EstadoMensaje1 { get; set; } = null!;

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
}
