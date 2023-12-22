using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class AvanceJuego
{
    public int IdAvanceJuego { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<JuegosUsuario> JuegosUsuarios { get; set; } = new List<JuegosUsuario>();
}
