﻿using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class GeneroJuego
{
    public int IdGeneroJuego { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Juego> Juegos { get; set; } = new List<Juego>();
}
