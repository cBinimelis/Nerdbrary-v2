using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class Mensaje
{
    public int IdMensaje { get; set; }

    public int IdUsuario { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdEstadoMensaje { get; set; }

    public virtual EstadoMensaje IdEstadoMensajeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
