using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SOLTECSA.Models;

public partial class SoltecsaContext : DbContext
{
    public SoltecsaContext()
    {
    }

    public SoltecsaContext(DbContextOptions<SoltecsaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Nomina> Nominas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:BDconexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__5295297CA9D72FFE");

            entity.ToTable("Empleado");

            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cedula");
            entity.Property(e => e.Dirección)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dirección");
            entity.Property(e => e.Edad)
                .HasComputedColumnSql("(datediff(year,[fechaNacimiento],getdate())-case when datepart(month,[fechaNacimiento])>datepart(month,getdate()) OR datepart(month,[fechaNacimiento])=datepart(month,getdate()) AND datepart(day,[fechaNacimiento])>datepart(day,getdate()) then (1) else (0) end)", false)
                .HasColumnName("edad");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_civil");
            entity.Property(e => e.EstudiosCertificaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_certificaciones");
            entity.Property(e => e.EstudiosDiplomado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_diplomado");
            entity.Property(e => e.EstudiosDoctorado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_doctorado");
            entity.Property(e => e.EstudiosPostgrado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_postgrado");
            entity.Property(e => e.EstudiosPrimaria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_primaria");
            entity.Property(e => e.EstudiosSecundaria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_secundaria");
            entity.Property(e => e.EstudiosTecnicos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_tecnicos");
            entity.Property(e => e.EstudiosUniversitario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estudios_universitario");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fechaNacimiento");
            entity.Property(e => e.Hijos)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hijos");
            entity.Property(e => e.Madre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("madre");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Padre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("padre");
            entity.Property(e => e.Salario)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("salario");
        });

        modelBuilder.Entity<Nomina>(entity =>
        {
            entity.HasKey(e => e.IdNomina).HasName("PK__nomina__BB6DB6736639319A");

            entity.ToTable("nomina");

            entity.Property(e => e.IdNomina).HasColumnName("idNomina");
            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.Inns)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("inns");
            entity.Property(e => e.Ir)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("ir");
            entity.Property(e => e.Quincena)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("quincena");
            entity.Property(e => e.Salario)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("salario");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Nominas)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NOMINA_EMPLEADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
