﻿using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class GeneroLibro
{
    public int IdGeneroLibro { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
