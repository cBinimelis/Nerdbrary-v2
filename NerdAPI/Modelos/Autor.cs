﻿using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class Autor
{
    public int IdAutor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Detalles { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
