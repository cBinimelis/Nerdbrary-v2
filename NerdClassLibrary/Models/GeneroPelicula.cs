﻿using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Models;

public partial class GeneroPelicula
{
    public int IdGeneroPelicula { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
