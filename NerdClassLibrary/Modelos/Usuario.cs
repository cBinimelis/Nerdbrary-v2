using System;
using System.Collections.Generic;

namespace NerdClassLibrary.Modelos;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nick { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdEstadoUsuario { get; set; }

    public int IdTipoUsuario { get; set; }

    public string Imagen { get; set; } = null!;

    public string? Fondo { get; set; }

    public virtual ICollection<AnimeUsuario> AnimeUsuarios { get; set; } = new List<AnimeUsuario>();

    public virtual EstadoUsuario IdEstadoUsuarioNavigation { get; set; } = null!;

    public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<JuegosUsuario> JuegosUsuarios { get; set; } = new List<JuegosUsuario>();

    public virtual ICollection<LibroUsuario> LibroUsuarios { get; set; } = new List<LibroUsuario>();

    public virtual ICollection<MangaUsuario> MangaUsuarios { get; set; } = new List<MangaUsuario>();

    public virtual ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();

    public virtual ICollection<PeliculaUsuario> PeliculaUsuarios { get; set; } = new List<PeliculaUsuario>();

    public virtual ICollection<Pendiente> Pendientes { get; set; } = new List<Pendiente>();

    public virtual ICollection<SerieUsuario> SerieUsuarios { get; set; } = new List<SerieUsuario>();
}
