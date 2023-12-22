﻿using System;
using System.Collections.Generic;

namespace NerdAPI.Modelos;

public partial class EstadoJuego
{
    public int IdEstadoJuegos { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Juego> Juegos { get; set; } = new List<Juego>();
}
