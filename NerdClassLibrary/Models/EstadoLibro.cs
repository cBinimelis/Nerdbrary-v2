using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class EstadoLibro
{
    public int IdEstadoLibro { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
