using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Nombre { get; set; } = null!;

    public string Sinopsis { get; set; } = null!;

    public int Paginas { get; set; }

    public DateTime Lanzamiento { get; set; }

    public string Imagen { get; set; } = null!;

    public int IdAutor { get; set; }

    public int IdGeneroLibro { get; set; }

    public string? OtrosGeneros { get; set; }

    public int IdEstadoLibro { get; set; }

    public bool Activo { get; set; }

    public virtual Autor IdAutorNavigation { get; set; } = null!;

    public virtual GeneroLibro IdEstadoLibro1 { get; set; } = null!;

    public virtual EstadoLibro IdEstadoLibroNavigation { get; set; } = null!;

    public virtual ICollection<LibroUsuario> LibroUsuarios { get; set; } = new List<LibroUsuario>();
}
