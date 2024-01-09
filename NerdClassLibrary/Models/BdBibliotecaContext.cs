using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NerdClassLibrary.Models;

//SCAFFOLD COMMAND
//Scaffold-DbContext "Server=localhost;Database=bd_biblioteca;Trusted_Connection=true;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


public partial class BdBibliotecaContext : DbContext
{
    public BdBibliotecaContext()
    {
    }

    public BdBibliotecaContext(DbContextOptions<BdBibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anime> Animes { get; set; }

    public virtual DbSet<AnimeUsuario> AnimeUsuarios { get; set; }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<AvanceAnime> AvanceAnimes { get; set; }

    public virtual DbSet<AvanceJuego> AvanceJuegos { get; set; }

    public virtual DbSet<AvanceLibro> AvanceLibros { get; set; }

    public virtual DbSet<AvanceManga> AvanceMangas { get; set; }

    public virtual DbSet<AvancePelicula> AvancePeliculas { get; set; }

    public virtual DbSet<AvanceSerie> AvanceSeries { get; set; }

    public virtual DbSet<Desarrollador> Desarrolladors { get; set; }

    public virtual DbSet<EstadoJuego> EstadoJuegos { get; set; }

    public virtual DbSet<EstadoLibro> EstadoLibros { get; set; }

    public virtual DbSet<EstadoManga> EstadoMangas { get; set; }

    public virtual DbSet<EstadoMensaje> EstadoMensajes { get; set; }

    public virtual DbSet<EstadoPelicula> EstadoPeliculas { get; set; }

    public virtual DbSet<EstadoSerie> EstadoSeries { get; set; }

    public virtual DbSet<EstadoUsuario> EstadoUsuarios { get; set; }

    public virtual DbSet<GeneroAnime> GeneroAnimes { get; set; }

    public virtual DbSet<GeneroJuego> GeneroJuegos { get; set; }

    public virtual DbSet<GeneroLibro> GeneroLibros { get; set; }

    public virtual DbSet<GeneroManga> GeneroMangas { get; set; }

    public virtual DbSet<GeneroPelicula> GeneroPeliculas { get; set; }

    public virtual DbSet<GeneroSerie> GeneroSeries { get; set; }

    public virtual DbSet<Juego> Juegos { get; set; }

    public virtual DbSet<JuegosUsuario> JuegosUsuarios { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<LibroUsuario> LibroUsuarios { get; set; }

    public virtual DbSet<Manga> Mangas { get; set; }

    public virtual DbSet<MangaUsuario> MangaUsuarios { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    public virtual DbSet<PeliculaUsuario> PeliculaUsuarios { get; set; }

    public virtual DbSet<Pendiente> Pendientes { get; set; }

    public virtual DbSet<SerieUsuario> SerieUsuarios { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<TipoPendiente> TipoPendientes { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VAnime> VAnimes { get; set; }

    public virtual DbSet<VJuego> VJuegos { get; set; }

    public virtual DbSet<VLibro> VLibros { get; set; }

    public virtual DbSet<VManga> VMangas { get; set; }

    public virtual DbSet<VPelicula> VPeliculas { get; set; }

    public virtual DbSet<VPendiente> VPendientes { get; set; }

    public virtual DbSet<VSeries> VSeries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=bd_biblioteca;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anime>(entity =>
        {
            entity.HasKey(e => e.IdAnime);

            entity.ToTable("Anime");

            entity.Property(e => e.IdAnime).HasColumnName("id_Anime");
            entity.Property(e => e.IdEstadoSerie).HasColumnName("id_EstadoSerie");
            entity.Property(e => e.IdGeneroAnime).HasColumnName("id_GeneroAnime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .HasColumnType("text")
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdEstadoSerieNavigation).WithMany(p => p.Animes)
                .HasForeignKey(d => d.IdEstadoSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anime_Estado");

            entity.HasOne(d => d.IdGeneroAnimeNavigation).WithMany(p => p.Animes)
                .HasForeignKey(d => d.IdGeneroAnime)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anime_Genero_Anime");
        });

        modelBuilder.Entity<AnimeUsuario>(entity =>
        {
            entity.HasKey(e => e.IdAnimeUsuario);

            entity.ToTable("Anime_Usuario");

            entity.Property(e => e.IdAnimeUsuario).HasColumnName("id_AnimeUsuario");
            entity.Property(e => e.IdAnime).HasColumnName("id_Anime");
            entity.Property(e => e.IdAvanceAnime).HasColumnName("id_AvanceAnime");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).IsUnicode(false);

            entity.HasOne(d => d.IdAnimeNavigation).WithMany(p => p.AnimeUsuarios)
                .HasForeignKey(d => d.IdAnime)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anime_Usuario_Anime");

            entity.HasOne(d => d.IdAvanceAnimeNavigation).WithMany(p => p.AnimeUsuarios)
                .HasForeignKey(d => d.IdAvanceAnime)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anime_Usuario_Estado_Anime_Usuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AnimeUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Anime_Usuario_Usuario");
        });

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK_Sagas");

            entity.ToTable("Autor");

            entity.Property(e => e.IdAutor).HasColumnName("id_Autor");
            entity.Property(e => e.Detalles).HasColumnType("text");
            entity.Property(e => e.Imagen)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AvanceAnime>(entity =>
        {
            entity.HasKey(e => e.IdAvanceAnime).HasName("PK_Estado_Anime_Usuario");

            entity.ToTable("Avance_Anime");

            entity.Property(e => e.IdAvanceAnime).HasColumnName("id_AvanceAnime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AvanceJuego>(entity =>
        {
            entity.HasKey(e => e.IdAvanceJuego);

            entity.ToTable("Avance_Juego");

            entity.Property(e => e.IdAvanceJuego).HasColumnName("id_AvanceJuego");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<AvanceLibro>(entity =>
        {
            entity.HasKey(e => e.IdAvanceLibro);

            entity.ToTable("Avance_Libro");

            entity.Property(e => e.IdAvanceLibro).HasColumnName("id_AvanceLibro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AvanceManga>(entity =>
        {
            entity.HasKey(e => e.IdAvanceManga);

            entity.ToTable("Avance_Manga");

            entity.Property(e => e.IdAvanceManga).HasColumnName("id_AvanceManga");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AvancePelicula>(entity =>
        {
            entity.HasKey(e => e.IdAvancePelicula);

            entity.ToTable("Avance_Pelicula");

            entity.Property(e => e.IdAvancePelicula).HasColumnName("id_AvancePelicula");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<AvanceSerie>(entity =>
        {
            entity.HasKey(e => e.IdAvanceSerie);

            entity.ToTable("Avance_Serie");

            entity.Property(e => e.IdAvanceSerie).HasColumnName("id_AvanceSerie");
            entity.Property(e => e.Descripcion).IsUnicode(false);
        });

        modelBuilder.Entity<Desarrollador>(entity =>
        {
            entity.HasKey(e => e.IdDesarrollador);

            entity.ToTable("Desarrollador");

            entity.Property(e => e.IdDesarrollador).HasColumnName("id_Desarrollador");
            entity.Property(e => e.Detalles).HasColumnType("text");
            entity.Property(e => e.Imagen)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoJuego>(entity =>
        {
            entity.HasKey(e => e.IdEstadoJuegos);

            entity.ToTable("Estado_Juegos");

            entity.Property(e => e.IdEstadoJuegos).HasColumnName("id_EstadoJuegos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoLibro>(entity =>
        {
            entity.HasKey(e => e.IdEstadoLibro);

            entity.ToTable("Estado_Libro");

            entity.Property(e => e.IdEstadoLibro).HasColumnName("id_EstadoLibro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoManga>(entity =>
        {
            entity.HasKey(e => e.IdEstadoManga);

            entity.ToTable("Estado_Manga");

            entity.Property(e => e.IdEstadoManga).HasColumnName("id_EstadoManga");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoMensaje>(entity =>
        {
            entity.HasKey(e => e.IdEstadoMensaje);

            entity.ToTable("Estado_Mensaje");

            entity.Property(e => e.IdEstadoMensaje).HasColumnName("id_EstadoMensaje");
            entity.Property(e => e.EstadoMensaje1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EstadoMensaje");
        });

        modelBuilder.Entity<EstadoPelicula>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPelicula);

            entity.ToTable("Estado_Pelicula");

            entity.Property(e => e.IdEstadoPelicula).HasColumnName("id_EstadoPelicula");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoSerie>(entity =>
        {
            entity.HasKey(e => e.IdEstadoSerie).HasName("PK_Estado");

            entity.ToTable("Estado_Serie");

            entity.Property(e => e.IdEstadoSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_EstadoSerie");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdEstadoUsuario);

            entity.ToTable("Estado_Usuario");

            entity.Property(e => e.IdEstadoUsuario).HasColumnName("id_EstadoUsuario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroAnime>(entity =>
        {
            entity.HasKey(e => e.IdGeneroAnime);

            entity.ToTable("Genero_Anime");

            entity.Property(e => e.IdGeneroAnime).HasColumnName("id_GeneroAnime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroJuego>(entity =>
        {
            entity.HasKey(e => e.IdGeneroJuego).HasName("PK_Juegos_Genero");

            entity.ToTable("Genero_Juegos");

            entity.Property(e => e.IdGeneroJuego).HasColumnName("id_GeneroJuego");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroLibro>(entity =>
        {
            entity.HasKey(e => e.IdGeneroLibro).HasName("PK_Genero");

            entity.ToTable("Genero_Libro");

            entity.Property(e => e.IdGeneroLibro).HasColumnName("id_GeneroLibro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroManga>(entity =>
        {
            entity.HasKey(e => e.IdGeneroManga);

            entity.ToTable("Genero_Mangas");

            entity.Property(e => e.IdGeneroManga).HasColumnName("id_GeneroManga");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroPelicula>(entity =>
        {
            entity.HasKey(e => e.IdGeneroPelicula);

            entity.ToTable("Genero_Pelicula");

            entity.Property(e => e.IdGeneroPelicula).HasColumnName("id_GeneroPelicula");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeneroSerie>(entity =>
        {
            entity.HasKey(e => e.IdGeneroSerie);

            entity.ToTable("Genero_Serie");

            entity.Property(e => e.IdGeneroSerie).HasColumnName("id_GeneroSerie");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Juego>(entity =>
        {
            entity.HasKey(e => e.IdJuego);

            entity.Property(e => e.IdJuego).HasColumnName("id_Juego");
            entity.Property(e => e.IdDesarrollador).HasColumnName("id_Desarrollador");
            entity.Property(e => e.IdEstadoJuego).HasColumnName("id_EstadoJuego");
            entity.Property(e => e.IdGeneroJuego).HasColumnName("id_GeneroJuego");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdDesarrolladorNavigation).WithMany(p => p.Juegos)
                .HasForeignKey(d => d.IdDesarrollador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Desarrollador");

            entity.HasOne(d => d.IdEstadoJuegoNavigation).WithMany(p => p.Juegos)
                .HasForeignKey(d => d.IdEstadoJuego)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Estado_Juegos");

            entity.HasOne(d => d.IdGeneroJuegoNavigation).WithMany(p => p.Juegos)
                .HasForeignKey(d => d.IdGeneroJuego)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Juegos_Genero");
        });

        modelBuilder.Entity<JuegosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdJuegoUsuario);

            entity.ToTable("Juegos_Usuario");

            entity.Property(e => e.IdJuegoUsuario).HasColumnName("id_JuegoUsuario");
            entity.Property(e => e.IdAvanceJuego).HasColumnName("id_AvanceJuego");
            entity.Property(e => e.IdJuego).HasColumnName("id_Juego");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).IsUnicode(false);

            entity.HasOne(d => d.IdAvanceJuegoNavigation).WithMany(p => p.JuegosUsuarios)
                .HasForeignKey(d => d.IdAvanceJuego)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Usuario_Avance_Juego");

            entity.HasOne(d => d.IdJuegoNavigation).WithMany(p => p.JuegosUsuarios)
                .HasForeignKey(d => d.IdJuego)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Usuario_Juegos");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.JuegosUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Juegos_Usuario_Usuario");
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro);

            entity.Property(e => e.IdLibro).HasColumnName("id_Libro");
            entity.Property(e => e.IdAutor).HasColumnName("id_Autor");
            entity.Property(e => e.IdEstadoLibro).HasColumnName("id_EstadoLibro");
            entity.Property(e => e.IdGeneroLibro).HasColumnName("id_GeneroLibro");
            entity.Property(e => e.Imagen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libros_Autor");

            entity.HasOne(d => d.IdEstadoLibroNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdEstadoLibro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libros_Estado_Libro");

            entity.HasOne(d => d.IdEstadoLibro1).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdEstadoLibro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libros_Genero");
        });

        modelBuilder.Entity<LibroUsuario>(entity =>
        {
            entity.HasKey(e => e.IdLibroUsuario);

            entity.ToTable("Libro_Usuario");

            entity.Property(e => e.IdLibroUsuario).HasColumnName("id_LibroUsuario");
            entity.Property(e => e.IdAvanceLibro).HasColumnName("id_AvanceLibro");
            entity.Property(e => e.IdLibro).HasColumnName("id_Libro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).IsUnicode(false);

            entity.HasOne(d => d.IdAvanceLibroNavigation).WithMany(p => p.LibroUsuarios)
                .HasForeignKey(d => d.IdAvanceLibro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libro_Usuario_Avance_Libro");

            entity.HasOne(d => d.IdLibroNavigation).WithMany(p => p.LibroUsuarios)
                .HasForeignKey(d => d.IdLibro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libro_Usuario_Libros");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LibroUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Libro_Usuario_Usuario");
        });

        modelBuilder.Entity<Manga>(entity =>
        {
            entity.HasKey(e => e.IdManga);

            entity.ToTable("Manga");

            entity.Property(e => e.IdManga).HasColumnName("id_Manga");
            entity.Property(e => e.IdEstadoManga).HasColumnName("id_EstadoManga");
            entity.Property(e => e.IdGeneroManga).HasColumnName("id_GeneroManga");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .HasColumnType("text")
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdEstadoMangaNavigation).WithMany(p => p.Mangas)
                .HasForeignKey(d => d.IdEstadoManga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manga_Estado_Manga");

            entity.HasOne(d => d.IdGeneroMangaNavigation).WithMany(p => p.Mangas)
                .HasForeignKey(d => d.IdGeneroManga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manga_Genero_Mangas");
        });

        modelBuilder.Entity<MangaUsuario>(entity =>
        {
            entity.HasKey(e => e.IdMangaUsuario);

            entity.ToTable("Manga_Usuario");

            entity.Property(e => e.IdMangaUsuario).HasColumnName("id_MangaUsuario");
            entity.Property(e => e.IdAvanceManga).HasColumnName("id_AvanceManga");
            entity.Property(e => e.IdManga).HasColumnName("id_Manga");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).IsUnicode(false);

            entity.HasOne(d => d.IdAvanceMangaNavigation).WithMany(p => p.MangaUsuarios)
                .HasForeignKey(d => d.IdAvanceManga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manga_Usuario_Avance_Manga");

            entity.HasOne(d => d.IdMangaNavigation).WithMany(p => p.MangaUsuarios)
                .HasForeignKey(d => d.IdManga)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manga_Usuario_Manga");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.MangaUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Manga_Usuario_Usuario");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.IdMensaje).HasName("PK_Notas");

            entity.Property(e => e.IdMensaje).HasColumnName("id_Mensaje");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.IdEstadoMensaje).HasColumnName("id_EstadoMensaje");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");

            entity.HasOne(d => d.IdEstadoMensajeNavigation).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.IdEstadoMensaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajes_Estado_Mensaje");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Mensajes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notas_Usuario");
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.IdPelicula);

            entity.Property(e => e.IdPelicula).HasColumnName("id_Pelicula");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEstadoPelicula).HasColumnName("id_EstadoPelicula");
            entity.Property(e => e.IdGeneroPelicula).HasColumnName("id_GeneroPelicula");
            entity.Property(e => e.Imagen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdEstadoPeliculaNavigation).WithMany(p => p.Peliculas)
                .HasForeignKey(d => d.IdEstadoPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Peliculas_Estado_Pelicula1");

            entity.HasOne(d => d.IdGeneroPeliculaNavigation).WithMany(p => p.Peliculas)
                .HasForeignKey(d => d.IdGeneroPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Peliculas_Genero_Pelicula");
        });

        modelBuilder.Entity<PeliculaUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPeliculaUsuario);

            entity.ToTable("Pelicula_Usuario");

            entity.Property(e => e.IdPeliculaUsuario).HasColumnName("id_PeliculaUsuario");
            entity.Property(e => e.IdAvancePelicula).HasColumnName("id_AvancePelicula");
            entity.Property(e => e.IdPelicula).HasColumnName("id_Pelicula");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).HasColumnType("text");

            entity.HasOne(d => d.IdAvancePeliculaNavigation).WithMany(p => p.PeliculaUsuarios)
                .HasForeignKey(d => d.IdAvancePelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pelicula_Usuario_Avance_Pelicula");

            entity.HasOne(d => d.IdPeliculaNavigation).WithMany(p => p.PeliculaUsuarios)
                .HasForeignKey(d => d.IdPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pelicula_Usuario_Peliculas");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.PeliculaUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pelicula_Usuario_Usuario");
        });

        modelBuilder.Entity<Pendiente>(entity =>
        {
            entity.HasKey(e => e.IdPendiente);

            entity.Property(e => e.IdPendiente).HasColumnName("id_Pendiente");
            entity.Property(e => e.IdTipoPendiente).HasColumnName("id_TipoPendiente");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoPendienteNavigation).WithMany(p => p.Pendientes)
                .HasForeignKey(d => d.IdTipoPendiente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pendientes_Tipo_Pendiente");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Pendientes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pendientes_Usuario");
        });

        modelBuilder.Entity<SerieUsuario>(entity =>
        {
            entity.HasKey(e => e.IdSerieUsuario);

            entity.ToTable("Serie_Usuario");

            entity.Property(e => e.IdSerieUsuario).HasColumnName("id_SerieUsuario");
            entity.Property(e => e.IdAvanceSerie).HasColumnName("id_AvanceSerie");
            entity.Property(e => e.IdSerie).HasColumnName("id_Serie");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Nota).IsUnicode(false);

            entity.HasOne(d => d.IdAvanceSerieNavigation).WithMany(p => p.SerieUsuarios)
                .HasForeignKey(d => d.IdAvanceSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Serie_Usuario_Avance_Serie");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.SerieUsuarios)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Serie_Usuario_Series");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SerieUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Serie_Usuario_Usuario");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.HasKey(e => e.IdSerie);

            entity.Property(e => e.IdSerie).HasColumnName("id_Serie");
            entity.Property(e => e.IdEstadoSerie).HasColumnName("id_EstadoSerie");
            entity.Property(e => e.IdGeneroSerie).HasColumnName("id_GeneroSerie");
            entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");
            entity.Property(e => e.Imagen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");

            entity.HasOne(d => d.IdEstadoSerieNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdEstadoSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Series_Estado");

            entity.HasOne(d => d.IdGeneroSerieNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdGeneroSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Series_Genero_Serie");
        });

        modelBuilder.Entity<TipoPendiente>(entity =>
        {
            entity.HasKey(e => e.IdTipoPendiente);

            entity.ToTable("Tipo_Pendiente");

            entity.Property(e => e.IdTipoPendiente).HasColumnName("id_TipoPendiente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario);

            entity.ToTable("Tipo_Usuario");

            entity.Property(e => e.IdTipoUsuario).HasColumnName("id_TipoUsuario");
            entity.Property(e => e.Descripción)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_Usuario");
            entity.Property(e => e.Fondo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdEstadoUsuario).HasColumnName("id_EstadoUsuario");
            entity.Property(e => e.IdTipoUsuario).HasColumnName("id_TipoUsuario");
            entity.Property(e => e.Imagen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nick)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEstadoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Estado_Usuario");

            entity.HasOne(d => d.IdTipoUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdTipoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Tipo_Usuario");
        });

        modelBuilder.Entity<VAnime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAnime");

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdAnime).HasColumnName("id_Anime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .HasColumnType("text")
                .HasColumnName("Otros Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        modelBuilder.Entity<VJuego>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vJuegos");

            entity.Property(e => e.Desarrollador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdDesarrollador).HasColumnName("id_Desarrollador");
            entity.Property(e => e.IdJuego).HasColumnName("id_Juego");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        modelBuilder.Entity<VLibro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vLibros");

            entity.Property(e => e.Autor)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdAutor).HasColumnName("id_Autor");
            entity.Property(e => e.IdLibro).HasColumnName("id_Libro");
            entity.Property(e => e.Imagen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        modelBuilder.Entity<VManga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vManga");

            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdManga).HasColumnName("id_Manga");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .HasColumnType("text")
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        modelBuilder.Entity<VPelicula>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPelicula");

            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdPelicula).HasColumnName("id_Pelicula");
            entity.Property(e => e.Imagen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros_Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        modelBuilder.Entity<VPendiente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPendientes");

            entity.Property(e => e.IdPendiente).HasColumnName("id_Pendiente");
            entity.Property(e => e.IdTipoPendiente).HasColumnName("id_TipoPendiente");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSeries>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vSeries");

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdSerie).HasColumnName("id_Serie");
            entity.Property(e => e.Imagen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Lanzamiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OtrosGeneros)
                .IsUnicode(false)
                .HasColumnName("Otros Generos");
            entity.Property(e => e.Sinopsis).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
