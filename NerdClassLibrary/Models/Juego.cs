using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class Juego
{
    public int IdJuego { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public int IdDesarrollador { get; set; }

    public DateOnly Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdGeneroJuego { get; set; }

    public string OtrosGeneros { get; set; } = null!;

    public int IdEstadoJuego { get; set; }

    public bool Activo { get; set; }

    public virtual Desarrollador IdDesarrolladorNavigation { get; set; } = null!;

    public virtual EstadoJuego IdEstadoJuegoNavigation { get; set; } = null!;

    public virtual GeneroJuego IdGeneroJuegoNavigation { get; set; } = null!;

    public virtual ICollection<JuegosUsuario> JuegosUsuarios { get; set; } = new List<JuegosUsuario>();
}
