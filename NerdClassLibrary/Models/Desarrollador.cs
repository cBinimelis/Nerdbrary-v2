using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class Desarrollador
{
    public int IdDesarrollador { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Detalles { get; set; }

    public string Imagen { get; set; } = null!;

    public virtual ICollection<Juego> Juegos { get; set; } = new List<Juego>();
}
