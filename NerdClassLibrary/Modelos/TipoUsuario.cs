using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string Descripción { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
