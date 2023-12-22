using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class AvanceLibro
{
    public int IdAvanceLibro { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LibroUsuario> LibroUsuarios { get; set; } = new List<LibroUsuario>();
}
