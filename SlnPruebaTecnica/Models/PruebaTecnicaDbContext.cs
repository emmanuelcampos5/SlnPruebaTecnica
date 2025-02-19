using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SlnPruebaTecnica.Models;

public partial class PruebaTecnicaDbContext : DbContext
{
    public PruebaTecnicaDbContext()
    {
    }

    public PruebaTecnicaDbContext(DbContextOptions<PruebaTecnicaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Residencium> Residencia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = PruebaTecnicaDB.mssql.somee.com;database=PruebaTecnicaDB;user id=emmanuelcampos55_SQLLogin_1;password=q8musngizk;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.IdNacionalidad).HasName("PK__Nacional__52613BE7DFD04C69");

            entity.ToTable("Nacionalidad");

            entity.Property(e => e.IdNacionalidad).HasColumnName("idNacionalidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Persona__3213E83FBC661E6A");

            entity.ToTable("Persona");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdNacionalidad).HasColumnName("idNacionalidad");
            entity.Property(e => e.IdResidencia).HasColumnName("idResidencia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdNacionalidad)
                .HasConstraintName("FK__Persona__idNacio__46E78A0C");

            entity.HasOne(d => d.IdResidenciaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdResidencia)
                .HasConstraintName("FK__Persona__idResid__45F365D3");
        });

        modelBuilder.Entity<Residencium>(entity =>
        {
            entity.HasKey(e => e.IdResidencia).HasName("PK__Residenc__95AB156AD3300D23");

            entity.Property(e => e.IdResidencia).HasColumnName("idResidencia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
