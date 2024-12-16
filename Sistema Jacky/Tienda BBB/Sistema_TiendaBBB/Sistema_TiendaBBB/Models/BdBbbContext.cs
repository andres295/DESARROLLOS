using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sistema_TiendaBBB.Models;

public partial class BdBbbContext : DbContext
{
    public BdBbbContext()
    {
    }

    public BdBbbContext(DbContextOptions<BdBbbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbCatArticulo> TbCatArticulos { get; set; }

    public virtual DbSet<TbCatCiudad> TbCatCiudads { get; set; }

    public virtual DbSet<TbCatClasificacionArt> TbCatClasificacionArts { get; set; }

    public virtual DbSet<TbCatClasificacionCte> TbCatClasificacionCtes { get; set; }

    public virtual DbSet<TbCatClasificacionProv> TbCatClasificacionProvs { get; set; }

    public virtual DbSet<TbCatCliente> TbCatClientes { get; set; }

    public virtual DbSet<TbCatMetodoPago> TbCatMetodoPagos { get; set; }

    public virtual DbSet<TbCatPai> TbCatPais { get; set; }

    public virtual DbSet<TbCatPresentacionArt> TbCatPresentacionArts { get; set; }

    public virtual DbSet<TbCatProveedor> TbCatProveedors { get; set; }

    public virtual DbSet<TbCatTipoIdentificacion> TbCatTipoIdentificacions { get; set; }

    public virtual DbSet<TbVenta> TbVentas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:BDconexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCatArticulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo).HasName("PK__tb_cat_a__AABB742236BDDF53");

            entity.ToTable("tb_cat_articulo");

            entity.Property(e => e.IdArticulo).HasColumnName("idArticulo");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("costoUnitario");
            entity.Property(e => e.DescripcionArticulo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionArticulo");
            entity.Property(e => e.Disponible).HasColumnName("disponible");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.IdPresentacion).HasColumnName("idPresentacion");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.TbCatArticulos)
                .HasForeignKey(d => d.IdClasificacion)
                .HasConstraintName("FK__tb_cat_ar__idCla__2A4B4B5E");

            entity.HasOne(d => d.IdPresentacionNavigation).WithMany(p => p.TbCatArticulos)
                .HasForeignKey(d => d.IdPresentacion)
                .HasConstraintName("FK__tb_cat_ar__idPre__2B3F6F97");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TbCatArticulos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK_Art_TbProveedor");
        });

        modelBuilder.Entity<TbCatCiudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PK__tb_cat_c__AEA2A71B1B47C554");

            entity.ToTable("tb_cat_ciudad");

            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.DescripcionCiudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcionCiudad");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatClasificacionArt>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion).HasName("PK__tb_cat_c__814AB99F0DFA2381");

            entity.ToTable("tb_cat_clasificacion_art");

            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.DescripcionClasificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionClasificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatClasificacionCte>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion).HasName("PK__tb_cat_c__814AB99FB4B6AA5C");

            entity.ToTable("tb_cat_clasificacion_cte");

            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.DescripcionClasificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionClasificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatClasificacionProv>(entity =>
        {
            entity.HasKey(e => e.IdClasificacion).HasName("PK__tb_cat_c__814AB99F71C383DC");

            entity.ToTable("tb_cat_clasificacion_prov");

            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.DescripcionClasificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionClasificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatCliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__tb_cat_c__885457EEDC196A4F");

            entity.ToTable("tb_cat_cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.IdIdentificacion).HasColumnName("idIdentificacion");
            entity.Property(e => e.IdPago).HasColumnName("idPago");
            entity.Property(e => e.IdPais).HasColumnName("idPais");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numeroIdentificacion");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.TbCatClientes)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_cl__idCiu__412EB0B6");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.TbCatClientes)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_cl__idCla__3D5E1FD2");

            entity.HasOne(d => d.IdIdentificacionNavigation).WithMany(p => p.TbCatClientes)
                .HasForeignKey(d => d.IdIdentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_cl__idIde__3F466844");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.TbCatClientes)
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_cl__idPag__3E52440B");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.TbCatClientes)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_cl__idPai__403A8C7D");
        });

        modelBuilder.Entity<TbCatMetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK__tb_cat_m__BD2295ADC2142AD3");

            entity.ToTable("tb_cat_metodo_pago");

            entity.Property(e => e.IdPago).HasColumnName("idPago");
            entity.Property(e => e.DescripcionPago)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionPago");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatPai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PK__tb_cat_p__BD2285E357787041");

            entity.ToTable("tb_cat_pais");

            entity.Property(e => e.IdPais).HasColumnName("idPais");
            entity.Property(e => e.DescripcionPais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcionPais");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatPresentacionArt>(entity =>
        {
            entity.HasKey(e => e.IdPresentacion).HasName("PK__tb_cat_p__2F353055D4103F09");

            entity.ToTable("tb_cat_presentacion_art");

            entity.Property(e => e.IdPresentacion).HasColumnName("idPresentacion");
            entity.Property(e => e.DescripcionPresentacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionPresentacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbCatProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__tb_cat_p__A3FA8E6B435712C5");

            entity.ToTable("tb_cat_proveedor");

            entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.IdClasificacion).HasColumnName("idClasificacion");
            entity.Property(e => e.IdIdentificacion).HasColumnName("idIdentificacion");
            entity.Property(e => e.IdPago).HasColumnName("idPago");
            entity.Property(e => e.IdPais).HasColumnName("idPais");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreProveedor");
            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numeroIdentificacion");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.TbCatProveedors)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_pr__idCiu__4BAC3F29");

            entity.HasOne(d => d.IdClasificacionNavigation).WithMany(p => p.TbCatProveedors)
                .HasForeignKey(d => d.IdClasificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_pr__idCla__47DBAE45");

            entity.HasOne(d => d.IdIdentificacionNavigation).WithMany(p => p.TbCatProveedors)
                .HasForeignKey(d => d.IdIdentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_pr__idIde__49C3F6B7");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.TbCatProveedors)
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_pr__idPag__48CFD27E");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.TbCatProveedors)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_cat_pr__idPai__4AB81AF0");
        });

        modelBuilder.Entity<TbCatTipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.IdIdentificacion).HasName("PK__tb_cat_t__E911EE429C81373C");

            entity.ToTable("tb_cat_tipo_identificacion");

            entity.Property(e => e.IdIdentificacion).HasColumnName("idIdentificacion");
            entity.Property(e => e.DescripcionIdentificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcionIdentificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<TbVenta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__tb_venta__077D56143344AD1E");

            entity.ToTable("tb_ventas");

            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdArticulo).HasColumnName("idArticulo");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioUnitario");
            entity.Property(e => e.Subtotal)
                .HasComputedColumnSql("([cantidad]*[precioUnitario])", true)
                .HasColumnType("decimal(21, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.TbVenta)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK__tb_ventas__fecha__628FA481");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbVenta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__tb_ventas__idCli__6383C8BA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
