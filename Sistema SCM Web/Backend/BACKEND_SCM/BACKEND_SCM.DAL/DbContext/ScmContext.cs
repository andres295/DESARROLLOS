using System;
using System.Collections.Generic;
using BACKEND_SCM.MODEL;
using Microsoft.EntityFrameworkCore;

namespace BACKEND_SCM.DAL;

public partial class ScmContext : DbContext
{
    public ScmContext()
    {
    }

    public ScmContext(DbContextOptions<ScmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminRegistroGasto> AdminRegistroGastos { get; set; }

    public virtual DbSet<AjusteTecla> AjusteTeclas { get; set; }

    public virtual DbSet<AperturaCaja> AperturaCajas { get; set; }

    public virtual DbSet<ArchivoExamenesGeneralHc> ArchivoExamenesGeneralHcs { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BuzonPedido> BuzonPedidos { get; set; }

    public virtual DbSet<CargoAjuste> CargoAjustes { get; set; }

    public virtual DbSet<CargoAjusteProducto> CargoAjusteProductos { get; set; }

    public virtual DbSet<CargoAjusteProductosTemp> CargoAjusteProductosTemps { get; set; }

    public virtual DbSet<CargoCompra> CargoCompras { get; set; }

    public virtual DbSet<CargoCompraProducto> CargoCompraProductos { get; set; }

    public virtual DbSet<CargoCompraProductosTemp> CargoCompraProductosTemps { get; set; }

    public virtual DbSet<CargoTransferenciaProducto> CargoTransferenciaProductos { get; set; }

    public virtual DbSet<CargoTransferenciaProductosTemp> CargoTransferenciaProductosTemps { get; set; }

    public virtual DbSet<CargoTransferencium> CargoTransferencia { get; set; }

    public virtual DbSet<CatGasto> CatGastos { get; set; }

    public virtual DbSet<Catalogo> Catalogos { get; set; }

    public virtual DbSet<CatalogoBk> CatalogoBks { get; set; }

    public virtual DbSet<CatalogoTipo> CatalogoTipos { get; set; }

    public virtual DbSet<CierreCaja> CierreCajas { get; set; }

    public virtual DbSet<CierreCajaMultiPago> CierreCajaMultiPagos { get; set; }

    public virtual DbSet<CitaPaciente> CitaPacientes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<CodigosVenta> CodigosVentas { get; set; }

    public virtual DbSet<ComposicionProducto> ComposicionProductos { get; set; }

    public virtual DbSet<ComposicionQuimica> ComposicionQuimicas { get; set; }

    public virtual DbSet<ComprobantesSri> ComprobantesSris { get; set; }

    public virtual DbSet<ConsultasExternaAnamnesi> ConsultasExternaAnamneses { get; set; }

    public virtual DbSet<ControlScoreMama> ControlScoreMamas { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<CotizacionesProducto> CotizacionesProductos { get; set; }

    public virtual DbSet<CotizacionesProductosTemp> CotizacionesProductosTemps { get; set; }

    public virtual DbSet<DescargoAjuste> DescargoAjustes { get; set; }

    public virtual DbSet<DescargoAjusteProducto> DescargoAjusteProductos { get; set; }

    public virtual DbSet<DescargoAjusteProductosTemp> DescargoAjusteProductosTemps { get; set; }

    public virtual DbSet<DescargoTransferenciaProducto> DescargoTransferenciaProductos { get; set; }

    public virtual DbSet<DescargoTransferenciaProductosTemp> DescargoTransferenciaProductosTemps { get; set; }

    public virtual DbSet<DescargoTransferencium> DescargoTransferencia { get; set; }

    public virtual DbSet<DescuentoCategorium> DescuentoCategoria { get; set; }

    public virtual DbSet<DescuentoCombo> DescuentoCombos { get; set; }

    public virtual DbSet<DescuentoComboProducto> DescuentoComboProductos { get; set; }

    public virtual DbSet<DescuentoLineaProducto> DescuentoLineaProductos { get; set; }

    public virtual DbSet<DescuentoLineaProductoDet> DescuentoLineaProductoDets { get; set; }

    public virtual DbSet<DetFacturaCxC> DetFacturaCxCs { get; set; }

    public virtual DbSet<DetFacturaCxCTemp> DetFacturaCxCTemps { get; set; }

    public virtual DbSet<DocumentosVenta> DocumentosVentas { get; set; }

    public virtual DbSet<EgresosCaja> EgresosCajas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<EspecialidadMedico> EspecialidadMedicos { get; set; }

    public virtual DbSet<Especialistum> Especialista { get; set; }

    public virtual DbSet<Especificacione> Especificaciones { get; set; }

    public virtual DbSet<ExamenFormularioPaciente> ExamenFormularioPacientes { get; set; }

    public virtual DbSet<ExamenPaciente> ExamenPacientes { get; set; }

    public virtual DbSet<ExamenesGeneralHc> ExamenesGeneralHcs { get; set; }

    public virtual DbSet<ExamenesHistoriaClinica> ExamenesHistoriaClinicas { get; set; }

    public virtual DbSet<FacturaCxC> FacturaCxCs { get; set; }

    public virtual DbSet<FacturasPorCobrar> FacturasPorCobrars { get; set; }

    public virtual DbSet<FacturasPorCobrarAbono> FacturasPorCobrarAbonos { get; set; }

    public virtual DbSet<FacturasPorCobrarDetallesProducto> FacturasPorCobrarDetallesProductos { get; set; }

    public virtual DbSet<FacturasPorCobrarProducto> FacturasPorCobrarProductos { get; set; }

    public virtual DbSet<FacturasPorPagar> FacturasPorPagars { get; set; }

    public virtual DbSet<FacturasPorPagarAbono> FacturasPorPagarAbonos { get; set; }

    public virtual DbSet<FacturasPorPagarProducto> FacturasPorPagarProductos { get; set; }

    public virtual DbSet<FacturasSeleccionada> FacturasSeleccionadas { get; set; }

    public virtual DbSet<HVenta> HVentas { get; set; }

    public virtual DbSet<HVentasPago> HVentasPagos { get; set; }

    public virtual DbSet<HVentasProducto> HVentasProductos { get; set; }

    public virtual DbSet<IdDetalleVentum> IdDetalleVenta { get; set; }

    public virtual DbSet<Iva> Ivas { get; set; }

    public virtual DbSet<LogsErrorPagoVentum> LogsErrorPagoVenta { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<NotasCredito> NotasCreditos { get; set; }

    public virtual DbSet<NotasCreditosCxc> NotasCreditosCxcs { get; set; }

    public virtual DbSet<NotasCreditosProducto> NotasCreditosProductos { get; set; }

    public virtual DbSet<NotasCreditosProductosCxc> NotasCreditosProductosCxcs { get; set; }

    public virtual DbSet<NotasCreditosProductosTemp> NotasCreditosProductosTemps { get; set; }

    public virtual DbSet<NotasCreditosProductosTempCxc> NotasCreditosProductosTempCxcs { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<ParametrosSri> ParametrosSris { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PorcentajeIva> PorcentajeIvas { get; set; }

    public virtual DbSet<Presentacione> Presentaciones { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosBitacora> ProductosBitacoras { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<RetencionesSri> RetencionesSris { get; set; }

    public virtual DbSet<RetencionesSridet> RetencionesSridets { get; set; }

    public virtual DbSet<RetencionesVentaDet> RetencionesVentaDets { get; set; }

    public virtual DbSet<RetencionesVentum> RetencionesVenta { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<SolicitudProducto> SolicitudProductos { get; set; }

    public virtual DbSet<StockProducto> StockProductos { get; set; }

    public virtual DbSet<TbBitacoraUpdateProducto> TbBitacoraUpdateProductos { get; set; }

    public virtual DbSet<TblcatalogosGenerale> TblcatalogosGenerales { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketsConsecutivo> TicketsConsecutivos { get; set; }

    public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<TmpArchivoExamenesGeneralHc> TmpArchivoExamenesGeneralHcs { get; set; }

    public virtual DbSet<TmpFacturasPorCobrarAbono> TmpFacturasPorCobrarAbonos { get; set; }

    public virtual DbSet<TmpFacturasPorPagarAbono> TmpFacturasPorPagarAbonos { get; set; }

    public virtual DbSet<TmpRetencionesSridet> TmpRetencionesSridets { get; set; }

    public virtual DbSet<TmpRetencionesVentaDet> TmpRetencionesVentaDets { get; set; }

    public virtual DbSet<TmpVentasPago> TmpVentasPagos { get; set; }

    public virtual DbSet<TpmExamenFormularioPaciente> TpmExamenFormularioPacientes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioPermiso> UsuarioPermisos { get; set; }

    public virtual DbSet<UsuariosWeb> UsuariosWebs { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentaPrecioEspecial> VentaPrecioEspecials { get; set; }

    public virtual DbSet<VentasPago> VentasPagos { get; set; }

    public virtual DbSet<VentasProducto> VentasProductos { get; set; }

    public virtual DbSet<VentasProductosTemp> VentasProductosTemps { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }   


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminRegistroGasto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin_Re__3214EC073BA3C482");

            entity.ToTable("Admin_Registro_Gastos");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaElimina).HasColumnName("Fecha_Elimina");
            entity.Property(e => e.IdGasto).HasColumnName("Id_Gasto");
            entity.Property(e => e.Monto).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.UserElimina).HasColumnName("User_Elimina");
        });

        modelBuilder.Entity<AjusteTecla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AjusteTe__3214EC071C8CEB6F");

            entity.ToTable("AjusteTecla");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
        });

        modelBuilder.Entity<AperturaCaja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Apertura__3214EC07D3391E46");

            entity.ToTable("Apertura_Caja");

            entity.Property(e => e.FechaApertura).HasColumnName("Fecha_Apertura");
            entity.Property(e => e.FechaHoraRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoApertura)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Apertura");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AperturaCajas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Apertura___Id_Us__3335971A");
        });

        modelBuilder.Entity<ArchivoExamenesGeneralHc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ArchivoE__3214EC07EBC90537");

            entity.ToTable("ArchivoExamenesGeneralHC");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.ExtArchivo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdExamenGeneralHc).HasColumnName("IdExamenGeneralHC");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bancos__3214EC07E1BEA676");

            entity.Property(e => e.Banco1).HasColumnName("Banco");
        });

        modelBuilder.Entity<BuzonPedido>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.HoraRegistro)
                .HasPrecision(0)
                .HasColumnName("Hora_Registro");
            entity.Property(e => e.Pvf).HasColumnName("PVF");
        });

        modelBuilder.Entity<CargoAjuste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoAju__3214EC07AF7E95F7");

            entity.ToTable("CargoAjuste");

            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_Documento");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdLaboratorio).HasColumnName("Id_Laboratorio");
            entity.Property(e => e.IdResp).HasColumnName("Id_Resp");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdLaboratorioNavigation).WithMany(p => p.CargoAjustes)
                .HasForeignKey(d => d.IdLaboratorio)
                .HasConstraintName("FK__CargoAjus__Id_La__7EC1CEDB");

            entity.HasOne(d => d.IdRespNavigation).WithMany(p => p.CargoAjusteIdRespNavigations)
                .HasForeignKey(d => d.IdResp)
                .HasConstraintName("FK__CargoAjus__Id_Re__7CD98669");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.CargoAjusteMaquinaNavigations)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__CargoAjus__Maqui__7DCDAAA2");
        });

        modelBuilder.Entity<CargoAjusteProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoAju__3214EC0764C62427");

            entity.ToTable("CargoAjuste_Productos");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.CargoAjusteProductos)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__CargoAjus__Maqui__7FB5F314");
        });

        modelBuilder.Entity<CargoAjusteProductosTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoAju__3214EC07FE96DF32");

            entity.ToTable("CargoAjuste_Productos_Temp");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CargoCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CargoCompra");

            entity.Property(e => e.DescPorc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Desc_Porc");
            entity.Property(e => e.DiasPago).HasColumnName("Dias_Pago");
            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_Documento");
            entity.Property(e => e.FechaHoraReg)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Reg");
            entity.Property(e => e.FechaPago).HasColumnName("Fecha_Pago");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
        });

        modelBuilder.Entity<CargoCompraProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoCom__3214EC07CAAA6FA7");

            entity.ToTable("CargoCompra_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdPresentacionNavigation).WithMany(p => p.CargoCompraProductos)
                .HasForeignKey(d => d.IdPresentacion)
                .HasConstraintName("FK__CargoComp__Id_Pr__00AA174D");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.CargoCompraProductos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__CargoComp__Id_Pr__019E3B86");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CargoCompraProductos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__CargoComp__Id_Us__02925FBF");
        });

        modelBuilder.Entity<CargoCompraProductosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CargoCompra_Productos_Temp");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CargoTransferenciaProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoTra__3214EC07CD524E87");

            entity.ToTable("CargoTransferencia_Productos");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.CargoTransferenciaProductos)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__CargoTran__Maqui__23F3538A");
        });

        modelBuilder.Entity<CargoTransferenciaProductosTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CargoTra__3214EC07AB4A94E1");

            entity.ToTable("CargoTransferencia_Productos_Temp");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CargoTransferencium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_Documento");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdLaboratorio).HasColumnName("Id_Laboratorio");
            entity.Property(e => e.IdResp).HasColumnName("Id_Resp");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdLaboratorioNavigation).WithMany()
                .HasForeignKey(d => d.IdLaboratorio)
                .HasConstraintName("FK__CargoTran__Id_La__2022C2A6");

            entity.HasOne(d => d.IdRespNavigation).WithMany()
                .HasForeignKey(d => d.IdResp)
                .HasConstraintName("FK__CargoTran__Id_Re__2116E6DF");

            entity.HasOne(d => d.MaquinaNavigation).WithMany()
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__CargoTran__Maqui__220B0B18");
        });

        modelBuilder.Entity<CatGasto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cat_Gast__3214EC07EE42C7F7");

            entity.ToTable("Cat_Gastos");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Estado).HasDefaultValue(true);
        });

        modelBuilder.Entity<Catalogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogo__3214EC07BE89E400");

            entity.ToTable("Catalogo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<CatalogoBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatalogoBk");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<CatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalogo__3214EC07AAB47FE9");

            entity.ToTable("CatalogoTipo");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<CierreCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cierre_Caja");

            entity.HasIndex(e => e.IdAperturaCaja, "Id_Apertura_Caja").IsUnique();

            entity.Property(e => e.FechaHoraRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdAperturaCaja).HasColumnName("Id_Apertura_Caja");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoApertura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoEgresos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoFaltante).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoIngresos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoSistema).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoSobrante).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MontoTotalCierre).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTotalEfectivoBillete).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTotalEfectivoMoneda).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTotalUsuario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdAperturaCajaNavigation).WithOne()
                .HasForeignKey<CierreCaja>(d => d.IdAperturaCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cierre_Ca__Id_Ap__39E294A9");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cierre_Ca__Id_Us__3AD6B8E2");
        });

        modelBuilder.Entity<CierreCajaMultiPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CierreCa__3214EC07D00D8CED");

            entity.ToTable("CierreCajaMultiPago");

            entity.Property(e => e.IdApertura).HasColumnName("Id_Apertura");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CitaPaciente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CitaPaciente");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCita).HasColumnName("Fecha_Cita");
            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
            entity.Property(e => e.HoraCita).HasColumnName("Hora_Cita");
            entity.Property(e => e.HoraFinCita).HasColumnName("Hora__fin_Cita");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDoctor).HasColumnName("Id_Doctor");
            entity.Property(e => e.IdPaciente).HasColumnName("Id_Paciente");
            entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC076777EB05");

            entity.Property(e => e.Ciudad).IsUnicode(false);
            entity.Property(e => e.NombresApellidos).HasColumnName("Nombres_Apellidos");
            entity.Property(e => e.Ruc).HasColumnName("RUC");
        });

        modelBuilder.Entity<CodigosVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Codigos_Ventas");
        });

        modelBuilder.Entity<ComposicionProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Composic__3214EC07938476DB");

            entity.ToTable("Composicion_Producto");

            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
            entity.Property(e => e.IdComposicion).HasColumnName("Id_Composicion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

            entity.HasOne(d => d.IdComposicionNavigation).WithMany(p => p.ComposicionProductos)
                .HasForeignKey(d => d.IdComposicion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Composici__Id_Co__038683F8");
        });

        modelBuilder.Entity<ComposicionQuimica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Composic__3214EC07C5603F98");

            entity.ToTable("ComposicionQuimica");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
        });

        modelBuilder.Entity<ComprobantesSri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comproba__3214EC07B08F461C");

            entity.ToTable("ComprobantesSRI");

            entity.HasIndex(e => e.ClaveAcceso, "UQ__Comproba__8478844B62E175B4").IsUnique();

            entity.Property(e => e.Ambiente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClaveAcceso).HasMaxLength(250);
            entity.Property(e => e.Emision)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoEnvioSri)
                .HasMaxLength(50)
                .HasColumnName("EstadoEnvioSRI");
            entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");
            entity.Property(e => e.IdGestor).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MensajeRecepcionSri).HasColumnName("MensajeRecepcionSRI");
            entity.Property(e => e.NoFactura)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NumeroComprobante).HasMaxLength(50);
            entity.Property(e => e.TipoDocumento).HasMaxLength(50);
            entity.Property(e => e.TotalSinImpuestos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UsuarioEnviaSri)
                .HasMaxLength(50)
                .HasColumnName("UsuarioEnviaSRI");
            entity.Property(e => e.UsuarioGeneraDocumento).HasMaxLength(50);
        });

        modelBuilder.Entity<ConsultasExternaAnamnesi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONSULTA__3214EC0799A3E08F");

            entity.ToTable("CONSULTAS_EXTERNA_ANAMNESIS");

            entity.Property(e => e.DtFechaEvolucionMedicamentoA).HasColumnName("dtFechaEvolucionMedicamentoA");
            entity.Property(e => e.DtFechaEvolucionMedicamentoB).HasColumnName("dtFechaEvolucionMedicamentoB");
            entity.Property(e => e.EstadoConsulta).HasDefaultValue(true);
            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HitoriaClinica).IsUnicode(false);
            entity.Property(e => e.TxtAntecedentesFamiliaresA)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesFamiliaresA");
            entity.Property(e => e.TxtAntecedentesFamiliaresB)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesFamiliaresB");
            entity.Property(e => e.TxtAntecedentesFamiliaresC)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesFamiliaresC");
            entity.Property(e => e.TxtAntecedentesFamiliaresD)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesFamiliaresD");
            entity.Property(e => e.TxtAntecedentesPersonalesA)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesPersonalesA");
            entity.Property(e => e.TxtAntecedentesPersonalesB)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesPersonalesB");
            entity.Property(e => e.TxtAntecedentesPersonalesC)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesPersonalesC");
            entity.Property(e => e.TxtAntecedentesPersonalesD)
                .IsUnicode(false)
                .HasColumnName("txtAntecedentesPersonalesD");
            entity.Property(e => e.TxtDiagnosticoDefinitivoCie)
                .IsUnicode(false)
                .HasColumnName("txtDiagnosticoDefinitivoCIE");
            entity.Property(e => e.TxtDiagnosticoDefinitivoDiagnostico)
                .IsUnicode(false)
                .HasColumnName("txtDiagnosticoDefinitivoDiagnostico");
            entity.Property(e => e.TxtDiagnosticoPresuntivoCie)
                .IsUnicode(false)
                .HasColumnName("txtDiagnosticoPresuntivoCIE");
            entity.Property(e => e.TxtDiagnosticoPresuntivoDiagnostico)
                .IsUnicode(false)
                .HasColumnName("txtDiagnosticoPresuntivoDiagnostico");
            entity.Property(e => e.TxtEnfermedadProblemaActualA)
                .IsUnicode(false)
                .HasColumnName("txtEnfermedadProblemaActualA");
            entity.Property(e => e.TxtEnfermedadProblemaActualB)
                .IsUnicode(false)
                .HasColumnName("txtEnfermedadProblemaActualB");
            entity.Property(e => e.TxtEnfermedadProblemaActualC)
                .IsUnicode(false)
                .HasColumnName("txtEnfermedadProblemaActualC");
            entity.Property(e => e.TxtEnfermedadProblemaActualD)
                .IsUnicode(false)
                .HasColumnName("txtEnfermedadProblemaActualD");
            entity.Property(e => e.TxtExamenFisicoA)
                .IsUnicode(false)
                .HasColumnName("txtExamenFisicoA");
            entity.Property(e => e.TxtExamenFisicoB)
                .IsUnicode(false)
                .HasColumnName("txtExamenFisicoB");
            entity.Property(e => e.TxtExamenFisicoC)
                .IsUnicode(false)
                .HasColumnName("txtExamenFisicoC");
            entity.Property(e => e.TxtExamenFisicoD)
                .IsUnicode(false)
                .HasColumnName("txtExamenFisicoD");
            entity.Property(e => e.TxtMotivoConsultaA)
                .IsUnicode(false)
                .HasColumnName("txtMotivoConsultaA");
            entity.Property(e => e.TxtMotivoConsultaB)
                .IsUnicode(false)
                .HasColumnName("txtMotivoConsultaB");
            entity.Property(e => e.TxtMotivoConsultaC)
                .IsUnicode(false)
                .HasColumnName("txtMotivoConsultaC");
            entity.Property(e => e.TxtMotivoConsultaD)
                .IsUnicode(false)
                .HasColumnName("txtMotivoConsultaD");
            entity.Property(e => e.TxtPrescipcion1)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion1");
            entity.Property(e => e.TxtPrescipcion2)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion2");
            entity.Property(e => e.TxtPrescipcion3)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion3");
            entity.Property(e => e.TxtPrescipcion4)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion4");
            entity.Property(e => e.TxtPrescipcion5)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion5");
            entity.Property(e => e.TxtPrescipcion6)
                .IsUnicode(false)
                .HasColumnName("txtPrescipcion6");
            entity.Property(e => e.TxtRevisionOrganoSistemaA)
                .IsUnicode(false)
                .HasColumnName("txtRevisionOrganoSistemaA");
            entity.Property(e => e.TxtRevisionOrganoSistemaB)
                .IsUnicode(false)
                .HasColumnName("txtRevisionOrganoSistemaB");
            entity.Property(e => e.TxtRevisionOrganoSistemaC)
                .IsUnicode(false)
                .HasColumnName("txtRevisionOrganoSistemaC");
            entity.Property(e => e.TxtRevisionOrganoSistemaD)
                .IsUnicode(false)
                .HasColumnName("txtRevisionOrganoSistemaD");
            entity.Property(e => e.TxtSignoVitalMedicionCircunferenciaCuello)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionCircunferenciaCuello");
            entity.Property(e => e.TxtSignoVitalMedicionFrecuenciaRespitatoria)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionFrecuenciaRespitatoria");
            entity.Property(e => e.TxtSignoVitalMedicionPerimetroCadera)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionPerimetroCadera");
            entity.Property(e => e.TxtSignoVitalMedicionPerimetroCefalico)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionPerimetroCefalico");
            entity.Property(e => e.TxtSignoVitalMedicionPerimetroCintura)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionPerimetroCintura");
            entity.Property(e => e.TxtSignoVitalMedicionPeso)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionPeso");
            entity.Property(e => e.TxtSignoVitalMedicionTalla)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionTalla");
            entity.Property(e => e.TxtSignoVitalMedicionTemporalAuxiliar)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionTemporalAuxiliar");
            entity.Property(e => e.TxtSignoVitalMedicionTemporalBucal)
                .IsUnicode(false)
                .HasColumnName("txtSignoVitalMedicionTemporalBucal");
            entity.Property(e => e.TxtTratamientoDefinitivo)
                .IsUnicode(false)
                .HasColumnName("txtTratamientoDefinitivo");
            entity.Property(e => e.TxtTratamientoPresuntivoA)
                .IsUnicode(false)
                .HasColumnName("txtTratamientoPresuntivoA");
            entity.Property(e => e.TxtTratamientoPresuntivoB)
                .IsUnicode(false)
                .HasColumnName("txtTratamientoPresuntivoB");
        });

        modelBuilder.Entity<ControlScoreMama>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ControlS__3214EC07FE74EC25");

            entity.ToTable("ControlScoreMama");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaAtencion).HasColumnName("Fecha_Atencion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable");
        });

        modelBuilder.Entity<Cotizacione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.NameClienteTem)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Cotizacio__Id_Us__056ECC6A");

            entity.HasOne(d => d.MaquinaNavigation).WithMany()
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__Cotizacio__Maqui__047AA831");
        });

        modelBuilder.Entity<CotizacionesProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cotizaciones_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdCotizacion).HasColumnName("Id_Cotizacion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
        });

        modelBuilder.Entity<CotizacionesProductosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cotizaciones_Productos_Temp");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdCotizacion).HasColumnName("Id_Cotizacion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
        });

        modelBuilder.Entity<DescargoAjuste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descargo__3214EC072FFAACD3");

            entity.ToTable("DescargoAjuste");

            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_Documento");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdLaboratorio).HasColumnName("Id_Laboratorio");
            entity.Property(e => e.IdResp).HasColumnName("Id_Resp");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdLaboratorioNavigation).WithMany(p => p.DescargoAjustes)
                .HasForeignKey(d => d.IdLaboratorio)
                .HasConstraintName("FK__DescargoA__Id_La__0662F0A3");

            entity.HasOne(d => d.IdRespNavigation).WithMany(p => p.DescargoAjusteIdRespNavigations)
                .HasForeignKey(d => d.IdResp)
                .HasConstraintName("FK__DescargoA__Id_Re__084B3915");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.DescargoAjusteMaquinaNavigations)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__DescargoA__Maqui__075714DC");
        });

        modelBuilder.Entity<DescargoAjusteProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descargo__3214EC0738446EDB");

            entity.ToTable("DescargoAjuste_Productos");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.DescargoAjusteProductos)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__DescargoA__Maqui__093F5D4E");
        });

        modelBuilder.Entity<DescargoAjusteProductosTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descargo__3214EC075E197789");

            entity.ToTable("DescargoAjuste_Productos_Temp");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<DescargoTransferenciaProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descargo__3214EC0721E42069");

            entity.ToTable("DescargoTransferencia_Productos");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.DescargoTransferenciaProductos)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__DescargoT__Maqui__2AA05119");
        });

        modelBuilder.Entity<DescargoTransferenciaProductosTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descargo__3214EC07C5335392");

            entity.ToTable("DescargoTransferencia_Productos_Temp");

            entity.Property(e => e.CantidadTexto).HasColumnName("Cantidad_Texto");
            entity.Property(e => e.DisponibleTexto).HasColumnName("Disponible_Texto");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(200)
                .HasColumnName("Id_Producto");
            entity.Property(e => e.Lote).HasMaxLength(250);
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<DescargoTransferencium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaDocumento).HasColumnName("Fecha_Documento");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdLaboratorio).HasColumnName("Id_Laboratorio");
            entity.Property(e => e.IdResp).HasColumnName("Id_Resp");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdLaboratorioNavigation).WithMany()
                .HasForeignKey(d => d.IdLaboratorio)
                .HasConstraintName("FK__DescargoT__Id_La__26CFC035");

            entity.HasOne(d => d.IdRespNavigation).WithMany()
                .HasForeignKey(d => d.IdResp)
                .HasConstraintName("FK__DescargoT__Id_Re__27C3E46E");

            entity.HasOne(d => d.MaquinaNavigation).WithMany()
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__DescargoT__Maqui__28B808A7");
        });

        modelBuilder.Entity<DescuentoCategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC074ACF719F");

            entity.ToTable("Descuento_Categoria");

            entity.Property(e => e.CantMax).HasColumnName("Cant_Max");
            entity.Property(e => e.CantMin).HasColumnName("Cant_Min");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DescuentoDesde).HasColumnName("Descuento_Desde");
            entity.Property(e => e.DescuentoHasta).HasColumnName("Descuento_Hasta");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DescuentoCategoria)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Descuento__Id_Pr__43A1090D");
        });

        modelBuilder.Entity<DescuentoCombo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC072FF374B3");

            entity.ToTable("Descuento_Combo");

            entity.Property(e => e.CantMax).HasColumnName("Cant_Max");
            entity.Property(e => e.CantMin).HasColumnName("Cant_Min");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.PrecioCombo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Precio_Combo");
            entity.Property(e => e.VenceDesde).HasColumnName("Vence_Desde");
            entity.Property(e => e.VenceHasta).HasColumnName("Vence_Hasta");
        });

        modelBuilder.Entity<DescuentoComboProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC07BF64424E");

            entity.ToTable("Descuento_Combo_Productos");

            entity.Property(e => e.IdDescuentoCombo).HasColumnName("Id_Descuento_Combo");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

            entity.HasOne(d => d.IdDescuentoComboNavigation).WithMany(p => p.DescuentoComboProductos)
                .HasForeignKey(d => d.IdDescuentoCombo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Descuento__Id_De__2AF556D4");
        });

        modelBuilder.Entity<DescuentoLineaProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC07B86D51C2");

            entity.ToTable("Descuento_Linea_Producto");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.VenceDesde).HasColumnName("Vence_Desde");
            entity.Property(e => e.VenceHasta).HasColumnName("Vence_Hasta");
        });

        modelBuilder.Entity<DescuentoLineaProductoDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Descuent__3214EC0782C4FE15");

            entity.ToTable("Descuento_Linea_Producto_Det");

            entity.Property(e => e.IdDescuentoLinea).HasColumnName("Id_Descuento_Linea");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");

            entity.HasOne(d => d.IdDescuentoLineaNavigation).WithMany(p => p.DescuentoLineaProductoDets)
                .HasForeignKey(d => d.IdDescuentoLinea)
                .HasConstraintName("FK__Descuento__Id_De__4119A21D");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DescuentoLineaProductoDets)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Descuento__Id_Pr__420DC656");
        });

        modelBuilder.Entity<DetFacturaCxC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Det_Fact__3214EC07367913B9");

            entity.ToTable("Det_FacturaCxC");

            entity.Property(e => e.Cantidad).HasDefaultValue(1);
            entity.Property(e => e.Concepto).IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.IdContrato).HasColumnName("Id_Contrato");
            entity.Property(e => e.IdOrden).HasColumnName("Id_Orden");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<DetFacturaCxCTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Det_Fact__3214EC074B0EDCF7");

            entity.ToTable("Det_FacturaCxC_temp");

            entity.Property(e => e.Cantidad).HasDefaultValue(1);
            entity.Property(e => e.Concepto).IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.IdContrato).HasColumnName("Id_Contrato");
            entity.Property(e => e.IdOrden).HasColumnName("Id_Orden");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPagar).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<DocumentosVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Documentos_Ventas");
        });

        modelBuilder.Entity<EgresosCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Egresos_Caja");

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaHoraRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdAperturaCaja).HasColumnName("Id_Apertura_Caja");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoEgreso)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Egreso");

            entity.HasOne(d => d.IdAperturaCajaNavigation).WithMany()
                .HasForeignKey(d => d.IdAperturaCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Egresos_C__Id_Ap__361203C5");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Egresos_C__Id_Us__370627FE");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3214EC07EA8A4851");

            entity.Property(e => e.NombresApellidos).HasColumnName("Nombres_Apellidos");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especial__3214EC079DD24260");

            entity.ToTable("Especialidad");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<EspecialidadMedico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Especialidad_Medico");

            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdEspecialidad).HasColumnName("Id_Especialidad");
            entity.Property(e => e.IdMedico).HasColumnName("Id_Medico");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany()
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Especiali__Id_Es__318D45CA");

            entity.HasOne(d => d.IdMedicoNavigation).WithMany()
                .HasForeignKey(d => d.IdMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Especiali__Id_Me__32816A03");
        });

        modelBuilder.Entity<Especialistum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especial__3214EC079B7373E1");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.NombresApellidos).HasColumnName("Nombres_Apellidos");
        });

        modelBuilder.Entity<Especificacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especifi__3214EC0793F0F706");
        });

        modelBuilder.Entity<ExamenFormularioPaciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExamenFo__3214EC0709D6805B");

            entity.ToTable("ExamenFormularioPaciente");

            entity.Property(e => e.DescripcionValor).HasColumnName("Descripcion_Valor");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdDiagnosticoDefinitivoCie).HasColumnName("IdDiagnosticoDefinitivoCIE");
            entity.Property(e => e.IdDiagnosticoPresuntivoCie).HasColumnName("IdDiagnosticoPresuntivoCIE");
            entity.Property(e => e.IdExamenFisicoCp).HasColumnName("IdExamenFisicoCP");
            entity.Property(e => e.IdExamenFisicoSp).HasColumnName("IdExamenFisicoSP");
            entity.Property(e => e.IdTipoPatologiaCp).HasColumnName("IdTipoPatologiaCP");
            entity.Property(e => e.IdTipoPatologiaSp).HasColumnName("IdTipoPatologiaSP");
            entity.Property(e => e.UsuarioCrea).HasColumnName("Usuario_Crea");
        });

        modelBuilder.Entity<ExamenPaciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExamenPa__3214EC07A607CD28");

            entity.ToTable("ExamenPaciente");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaAtencion).HasColumnName("Fecha_Atencion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.UsuarioCrea).HasColumnName("Usuario_Crea");
        });

        modelBuilder.Entity<ExamenesGeneralHc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examenes__3214EC0729270CA7");

            entity.ToTable("ExamenesGeneralHC");

            entity.Property(e => e.Costo).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaAtencion).HasColumnName("Fecha_Atencion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Observacion).IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExamenesHistoriaClinica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examenes__3214EC0747D85F6C");

            entity.ToTable("ExamenesHistoriaClinica");

            entity.Property(e => e.Comentario).IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.ExtArchivo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FacturaCxC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FacturaC__3214EC079DA6C8A7");

            entity.ToTable("FacturaCxC");

            entity.Property(e => e.Abono).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaHoraRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdEspecialista).HasColumnName("Id_Especialista");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Moneda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("DOLARES");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(8, 4)");
            entity.Property(e => e.TipoVenta).HasColumnName("Tipo_Venta");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<FacturasPorCobrar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC07AF9E5449");

            entity.ToTable("FacturasPorCobrar");

            entity.Property(e => e.FechaEmision).HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.MontoAbonado)
                .HasColumnType("money")
                .HasColumnName("Monto_Abonado");
            entity.Property(e => e.MontoFact)
                .HasColumnType("money")
                .HasColumnName("Monto_Fact");
            entity.Property(e => e.MontoNc)
                .HasColumnType("money")
                .HasColumnName("Monto_NC");
            entity.Property(e => e.MontoRet)
                .HasColumnType("money")
                .HasColumnName("Monto_RET");
            entity.Property(e => e.MontoRetIva)
                .HasColumnType("money")
                .HasColumnName("Monto_RET_IVA");
            entity.Property(e => e.MontoSaldo)
                .HasColumnType("money")
                .HasColumnName("Monto_Saldo");
            entity.Property(e => e.MontoTotalPagar)
                .HasColumnType("money")
                .HasColumnName("Monto_TotalPagar");
            entity.Property(e => e.NumVenta).HasColumnName("Num_Venta");
            entity.Property(e => e.OrigenFactura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ORIGEN_FACTURA");
            entity.Property(e => e.RetencionIva).HasColumnName("Retencion_IVA");
            entity.Property(e => e.RetencionRenta).HasColumnName("Retencion_Renta");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.FacturasPorCobrars)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__FacturasP__Id_Cl__30E33A54");
        });

        modelBuilder.Entity<FacturasPorCobrarAbono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC0725559909");

            entity.ToTable("FacturasPorCobrar_Abonos");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCobro).HasColumnName("Fecha_Cobro");
            entity.Property(e => e.FechaHoraReg)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Reg");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.ImagenDoc).HasColumnName("Imagen_Doc");
            entity.Property(e => e.InteresMultiPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Interes_MultiPago");
            entity.Property(e => e.MontoEfectivo)
                .HasColumnType("money")
                .HasColumnName("Monto_Efectivo");
            entity.Property(e => e.MontoMultipago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Multipago");
            entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.FacturasPorCobrarAbonos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__FacturasP__Id_Us__294D0584");
        });

        modelBuilder.Entity<FacturasPorCobrarDetallesProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC07491031A2");

            entity.ToTable("FacturasPorCobrar_Detalles_Producto");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdCombo).HasColumnName("Id_Combo");
            entity.Property(e => e.IdPrecioEspecial).HasColumnName("Id_Precio_Especial");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubtotalCp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_CP");
            entity.Property(e => e.SubtotalDp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_DP");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
            entity.Property(e => e.Vendio).HasColumnType("decimal(8, 4)");
        });

        modelBuilder.Entity<FacturasPorCobrarProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturasPorCobrar_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.HoraRegistro)
                .HasPrecision(0)
                .HasColumnName("Hora_Registro");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UtilidadPorc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Utilidad_Porc");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__FacturasP__Id_Us__36A700A2");
        });

        modelBuilder.Entity<FacturasPorPagar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturasPorPagar", tb => tb.HasTrigger("trg_cambia_estado_cxp"));

            entity.Property(e => e.FechaEmision).HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.MontoFact)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Fact");
            entity.Property(e => e.MontoNc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_NC");
            entity.Property(e => e.MontoRetencion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Retencion");
            entity.Property(e => e.MontoTotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TotalPagar");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany()
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__FacturasP__Id_Pr__0B27A5C0");
        });

        modelBuilder.Entity<FacturasPorPagarAbono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC072D8CB401");

            entity.ToTable("FacturasPorPagar_Abonos");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCobro).HasColumnName("Fecha_Cobro");
            entity.Property(e => e.FechaHoraReg)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Reg");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.ImagenDoc).HasColumnName("Imagen_Doc");
            entity.Property(e => e.InteresMultiPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Interes_MultiPago");
            entity.Property(e => e.MontoEfectivo)
                .HasColumnType("money")
                .HasColumnName("Monto_Efectivo");
            entity.Property(e => e.MontoMultipago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Multipago");
            entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.FacturasPorPagarAbonos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__FacturasP__Id_Us__0C1BC9F9");
        });

        modelBuilder.Entity<FacturasPorPagarProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FacturasPorPagar_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_Registro");
            entity.Property(e => e.FechaVencimiento).HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.HoraRegistro)
                .HasPrecision(0)
                .HasColumnName("Hora_Registro");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UtilidadPorc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Utilidad_Porc");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__FacturasP__Id_Us__0D0FEE32");
        });

        modelBuilder.Entity<FacturasSeleccionada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Facturas_Seleccionadas");

            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MaquinaNavigation).WithMany()
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__Facturas___Maqui__0A338187");
        });

        modelBuilder.Entity<HVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hVentas");

            entity.Property(e => e.DateDelete)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Date_Delete");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.NameClienteTem)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NumDoc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoVenta).HasColumnName("Tipo_Venta");
            entity.Property(e => e.UerDelete)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())")
                .HasColumnName("Uer_Delete");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__hVentas__Id_Usua__4E0988E7");

            entity.HasOne(d => d.MaquinaNavigation).WithMany()
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__hVentas__Maquina__4EFDAD20");
        });

        modelBuilder.Entity<HVentasPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hVentas_Pago");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADQUIRENTE");
            entity.Property(e => e.ChequeMonto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cheque_Monto");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.ImagenCheque).HasColumnName("Imagen_Cheque");
            entity.Property(e => e.ImagenTranf).HasColumnName("Imagen_Tranf");
            entity.Property(e => e.MontoEfectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MontoTc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TC");
            entity.Property(e => e.MontoTd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TD");
            entity.Property(e => e.MontoTranf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Tranf");
            entity.Property(e => e.TcInteres)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TC_Interes");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");
        });

        modelBuilder.Entity<HVentasProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hVentas_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdCombo).HasColumnName("Id_Combo");
            entity.Property(e => e.IdPrecioEspecial).HasColumnName("Id_Precio_Especial");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubtotalCp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_CP");
            entity.Property(e => e.SubtotalDp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_DP");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
        });

        modelBuilder.Entity<IdDetalleVentum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("PK__idDetall__BFE2843F6497B57D");

            entity.ToTable("idDetalleVenta");

            entity.Property(e => e.IdDetalleVenta).HasColumnName("idDetalleVenta");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.IdDetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__idDetalle__idPro__31783731");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.IdDetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__idDetalle__idVen__308412F8");
        });

        modelBuilder.Entity<Iva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IVA");

            entity.Property(e => e.CodigoPorcIva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Codigo_Porc_Iva");
            entity.Property(e => e.CodigoSri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO_SRI");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<LogsErrorPagoVentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogsErro__3214EC27F960AC77");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__Menu__C26AF48374645811");

            entity.ToTable("Menu");

            entity.Property(e => e.IdMenu).HasColumnName("idMenu");
            entity.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("icono");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.IdMenuRol).HasName("PK__MenuRol__9D6D61A4AD31B01E");

            entity.ToTable("MenuRol");

            entity.Property(e => e.IdMenuRol).HasColumnName("idMenuRol");
            entity.Property(e => e.IdMenu).HasColumnName("idMenu");
            entity.Property(e => e.IdRol).HasColumnName("idRol");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__MenuRol__idMenu__2141CF68");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__MenuRol__idRol__2235F3A1");
        });

        modelBuilder.Entity<NotasCredito>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NotasCre__3214EC072636B49C");

            entity.Property(e => e.FechaEmision).HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdFacturaAfec).HasColumnName("Id_Factura_Afec");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Nc).HasColumnName("NC");
            entity.Property(e => e.Ruc).HasColumnName("RUC");
            entity.Property(e => e.TipoNc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TipoNC");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.NotasCreditos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__NotasCred__Id_Pr__0E04126B");
        });

        modelBuilder.Entity<NotasCreditosCxc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NotasCre__3214EC07AB2E82C5");

            entity.ToTable("NotasCreditosCXC");

            entity.Property(e => e.FechaEmision).HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdVentaAfec).HasColumnName("Id_Venta_Afec");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Nc).HasColumnName("NC");
            entity.Property(e => e.Ruc).HasColumnName("RUC");
            entity.Property(e => e.TipoNc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TipoNC");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.NotasCreditosCxcs)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__NotasCred__Id_Cl__24885067");
        });

        modelBuilder.Entity<NotasCreditosProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotasCreditos_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdNc).HasColumnName("Id_NC");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<NotasCreditosProductosCxc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotasCreditos_ProductosCXC");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdNc).HasColumnName("Id_NC");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<NotasCreditosProductosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotasCreditos_Productos_Temp");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdNc).HasColumnName("Id_NC");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<NotasCreditosProductosTempCxc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotasCreditos_Productos_TempCXC");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdNc).HasColumnName("Id_NC");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<NumeroDocumento>(entity =>
        {
            entity.HasKey(e => e.IdNumeroDocumento).HasName("PK__numeroDo__471E421A8C34163D");

            entity.ToTable("numeroDocumento");

            entity.Property(e => e.IdNumeroDocumento).HasColumnName("idNumeroDocumento");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.UltimoNumero).HasColumnName("ultimo_Numero");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3214EC0714B5495B");

            entity.ToTable("Paciente");

            entity.Property(e => e.NombresApellidos).HasColumnName("Nombres_Apellidos");
            entity.Property(e => e.Ruc).HasColumnName("RUC");
            entity.Property(e => e.Saldo).HasColumnType("decimal(8, 4)");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parametr__3214EC0706C79D1E");

            entity.Property(e => e.AltoPrintFactura)
                .HasMaxLength(30)
                .HasColumnName("Alto_Print_Factura");
            entity.Property(e => e.BkAutomatico).HasColumnName("BK_Automatico");
            entity.Property(e => e.BkDesde).HasColumnName("BK_Desde");
            entity.Property(e => e.BkHasta).HasColumnName("BK_Hasta");
            entity.Property(e => e.DiaVencimiento).HasColumnName("Dia_Vencimiento");
            entity.Property(e => e.Especialidades).HasMaxLength(200);
            entity.Property(e => e.NombreEmpresa).HasColumnName("Nombre_Empresa");
            entity.Property(e => e.NotaAvisoCm)
                .IsUnicode(false)
                .HasColumnName("NotaAvisoCM");
            entity.Property(e => e.NumItem).HasDefaultValue(0);
            entity.Property(e => e.Nvia)
                .IsUnicode(false)
                .HasColumnName("NVIA");
            entity.Property(e => e.Nvib)
                .IsUnicode(false)
                .HasColumnName("NVIB");
            entity.Property(e => e.RegistroSanitario).HasMaxLength(200);
            entity.Property(e => e.RutaBackup).HasColumnName("Ruta_Backup");
            entity.Property(e => e.RutaImagen).HasColumnName("Ruta_Imagen");
            entity.Property(e => e.StockProducto).HasColumnName("Stock_producto");
        });

        modelBuilder.Entity<ParametrosSri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parametr__3214EC076763A1A4");

            entity.ToTable("ParametrosSRI");

            entity.Property(e => e.Ambiente).HasMaxLength(50);
            entity.Property(e => e.CodDocSustento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Codestablecimiento).HasMaxLength(50);
            entity.Property(e => e.CodigoAgenteRetencion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CodigoNumerico).HasMaxLength(50);
            entity.Property(e => e.Codpuntoemision).HasMaxLength(50);
            entity.Property(e => e.ContrasenaSmtp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ContrasenaSMTP");
            entity.Property(e => e.CorreoSmtp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CorreoSMTP");
            entity.Property(e => e.ImpresoraTickets)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Moneda).HasMaxLength(50);
            entity.Property(e => e.MontoMinimoConsumidorFinal).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.NumContribuyente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ObligadoContabilidad).HasMaxLength(10);
            entity.Property(e => e.Regimen)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RutaXml)
                .IsUnicode(false)
                .HasColumnName("RutaXML");
            entity.Property(e => e.ServicioSractivo).HasColumnName("ServicioSRActivo");
            entity.Property(e => e.TipoDocumentoFactura).HasMaxLength(50);
            entity.Property(e => e.TipoDocumentoRetencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoEmision).HasMaxLength(50);
            entity.Property(e => e.UrlSriLocal)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL_SRI_LOCAL");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permisos__3214EC07F61661EA");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
            entity.Property(e => e.NumVentana)
                .IsUnicode(false)
                .HasColumnName("Num_Ventana");
        });

        modelBuilder.Entity<PorcentajeIva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Porcenta__3214EC07893F1E70");

            entity.ToTable("PorcentajeIva");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Presentacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presenta__3214EC07A1D321B5");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC07FE427959");

            entity.ToTable(tb => tb.HasTrigger("tgr_update_stock"));

            entity.HasIndex(e => e.IdComposicion, "index_composicion");

            entity.HasIndex(e => e.IdEspecificacion, "index_especificacion");

            entity.HasIndex(e => e.Id, "index_id_cod_barra");

            entity.HasIndex(e => e.IdPresentacion, "index_nombre_producto");

            entity.HasIndex(e => e.IdProveedor, "index_proveedor");

            entity.HasIndex(e => e.Vencimiento, "index_vencimiento");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DescuentoDesde).HasColumnName("Descuento_Desde");
            entity.Property(e => e.DescuentoHasta).HasColumnName("Descuento_Hasta");
            entity.Property(e => e.IdComposicion).HasColumnName("Id_Composicion");
            entity.Property(e => e.IdEspecificacion).HasColumnName("Id_Especificacion");
            entity.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Producto1).HasColumnName("Producto");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.PvpIva)
                .HasDefaultValue(false)
                .HasColumnName("Pvp_Iva");
            entity.Property(e => e.RegistroSanitario).HasMaxLength(200);
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdEspecificacionNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdEspecificacion)
                .HasConstraintName("FK__Productos__Id_Es__4959E263");

            entity.HasOne(d => d.IdPresentacionNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdPresentacion)
                .HasConstraintName("FK__Productos__Id_Pr__4865BE2A");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__Productos__Id_Pr__467D75B8");
        });

        modelBuilder.Entity<ProductosBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Productos_Bitacora");

            entity.Property(e => e.Accion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DescuentoDesde).HasColumnName("Descuento_Desde");
            entity.Property(e => e.DescuentoHasta).HasColumnName("Descuento_Hasta");
            entity.Property(e => e.IdComposicion).HasColumnName("Id_Composicion");
            entity.Property(e => e.IdEspecificacion).HasColumnName("Id_Especificacion");
            entity.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.PvpIva)
                .HasDefaultValue(false)
                .HasColumnName("Pvp_Iva");
            entity.Property(e => e.RegistroSanitario).HasMaxLength(200);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC0738DAC9DC");

            entity.Property(e => e.AgenteRetencion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Ruc).HasColumnName("RUC");
            entity.Property(e => e.Tipocontribuyente)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RetencionesSri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC077DC05D2B");

            entity.ToTable("RetencionesSRI");

            entity.HasIndex(e => e.NumConsecutivoSri, "UQ__Retencio__2CCA7D177C9FC2D6").IsUnique();

            entity.Property(e => e.ClaveAcceso).HasMaxLength(250);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NumConsecutivoSri).HasColumnName("NumConsecutivoSRI");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PeriodoFiscal).HasColumnType("datetime");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalValorRetenido).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RetencionesSridet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC07B4C0C16A");

            entity.ToTable("RetencionesSRIDet");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ImpuestoRetener)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcRetencion).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorRetenido).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<RetencionesVentaDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC07D7248519");

            entity.ToTable("RetencionesVentaDet");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ImpuestoRetener)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcRetencion).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorRetenido).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<RetencionesVentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC0744809798");

            entity.HasIndex(e => e.NumConsecutivoSri, "UQ__Retencio__2CCA7D1742F15E6C").IsUnique();

            entity.Property(e => e.ClaveAcceso).HasMaxLength(250);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NumConsecutivoSri).HasColumnName("NumConsecutivoSRI");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PeriodoFiscal).HasColumnType("datetime");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalValorRetenido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalValorRetenidoIva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalValorRetenidoIVA");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__3C872F764D7D9F53");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC07D3844B63");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Servicio1).HasColumnName("Servicio");
            entity.Property(e => e.TiempoEjecucion).HasColumnName("Tiempo_Ejecucion");
        });

        modelBuilder.Entity<SolicitudProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Solicitud_Producto");

            entity.Property(e => e.CantidadSolicita).HasColumnName("Cantidad_Solicita");
            entity.Property(e => e.Deposito).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaHoraRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

            entity.HasOne(d => d.IdProductoNavigation).WithMany()
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Solicitud__Id_Pr__08D548FA");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Solicitud__Id_Us__09C96D33");
        });

        modelBuilder.Entity<StockProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stock_Pr__3214EC0760721D66");

            entity.ToTable("Stock_Productos");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaAnula).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdFactura).HasColumnName("Id_Factura");
            entity.Property(e => e.IdPresentacion).HasColumnName("Id_Presentacion");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Pur)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PUR");
            entity.Property(e => e.Pvf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVF");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TipoMovimiento).HasMaxLength(50);
            entity.Property(e => e.TotalPagar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.StockProductos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__Stock_Pro__Id_Pr__36870511");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.StockProductos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Stock_Pro__Id_Us__377B294A");
        });

        modelBuilder.Entity<TbBitacoraUpdateProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_Bitac__3213E83F99948563");

            entity.ToTable("TB_Bitacora_Update_Productos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateLog)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date_log");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.Producto).IsUnicode(false);
            entity.Property(e => e.UserUpdate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())")
                .HasColumnName("user_update");
        });

        modelBuilder.Entity<TblcatalogosGenerale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TBLCatal__3214EC07C3A1677E");

            entity.ToTable("TBLCatalogosGenerales");

            entity.Property(e => e.CodAnexo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.PorcRetencion).HasColumnType("decimal(8, 4)");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tickets__3214EC07A4907DE1");

            entity.Property(e => e.FechaAtencion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdEspecialista).HasColumnName("Id_Especialista");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
        });

        modelBuilder.Entity<TicketsConsecutivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketsC__3214EC07C60125FF");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
        });

        modelBuilder.Entity<TipoIdentificacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_Identificacion");

            entity.Property(e => e.Codigo).HasMaxLength(10);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TipoIdentificacion1).HasColumnName("TipoIdentificacion");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tipo_Pag__3214EC076180F128");

            entity.ToTable("Tipo_Pago");

            entity.Property(e => e.CodigoSri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO_SRI");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<TmpArchivoExamenesGeneralHc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpArchi__3214EC073C3F0393");

            entity.ToTable("TmpArchivoExamenesGeneralHC");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.ExtArchivo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpFacturasPorCobrarAbono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpFactu__3214EC07C2C73EF1");

            entity.ToTable("TmpFacturasPorCobrar_Abonos");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCobro).HasColumnName("Fecha_Cobro");
            entity.Property(e => e.FechaHoraReg)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Reg");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.ImagenDoc).HasColumnName("Imagen_Doc");
            entity.Property(e => e.InteresMultiPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Interes_MultiPago");
            entity.Property(e => e.MontoEfectivo)
                .HasColumnType("money")
                .HasColumnName("Monto_Efectivo");
            entity.Property(e => e.MontoMultipago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Multipago");
            entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");
        });

        modelBuilder.Entity<TmpFacturasPorPagarAbono>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpFactu__3214EC07F8DF4749");

            entity.ToTable("TmpFacturasPorPagar_Abonos");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCobro).HasColumnName("Fecha_Cobro");
            entity.Property(e => e.FechaHoraReg)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Reg");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.ImagenDoc).HasColumnName("Imagen_Doc");
            entity.Property(e => e.InteresMultiPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Interes_MultiPago");
            entity.Property(e => e.MontoEfectivo)
                .HasColumnType("money")
                .HasColumnName("Monto_Efectivo");
            entity.Property(e => e.MontoMultipago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Multipago");
            entity.Property(e => e.NumDoc).HasColumnName("Num_Doc");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");
        });

        modelBuilder.Entity<TmpRetencionesSridet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpReten__3214EC076A500B0D");

            entity.ToTable("TmpRetencionesSRIDet");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ImpuestoRetener)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcRetencion).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorRetenido).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<TmpRetencionesVentaDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpReten__3214EC078B9A4EE2");

            entity.ToTable("TmpRetencionesVentaDet");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ImpuestoRetener)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorcRetencion).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorRetenido).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<TmpVentasPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TmpVenta__3214EC0743142341");

            entity.ToTable("TmpVentas_Pago");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADQUIRENTE");
            entity.Property(e => e.ChequeMonto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cheque_Monto");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.ImagenCheque).HasColumnName("Imagen_Cheque");
            entity.Property(e => e.ImagenTranf).HasColumnName("Imagen_Tranf");
            entity.Property(e => e.MontoEfectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MontoTc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TC");
            entity.Property(e => e.MontoTd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TD");
            entity.Property(e => e.MontoTranf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Tranf");
            entity.Property(e => e.TcInteres)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TC_Interes");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");
        });

        modelBuilder.Entity<TpmExamenFormularioPaciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TpmExame__3214EC07F2B55E74");

            entity.ToTable("TpmExamenFormularioPaciente");

            entity.Property(e => e.DescripcionValor).HasColumnName("Descripcion_Valor");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdDiagnosticoDefinitivoCie).HasColumnName("IdDiagnosticoDefinitivoCIE");
            entity.Property(e => e.IdDiagnosticoPresuntivoCie).HasColumnName("IdDiagnosticoPresuntivoCIE");
            entity.Property(e => e.IdExamenFisicoCp).HasColumnName("IdExamenFisicoCP");
            entity.Property(e => e.IdExamenFisicoSp).HasColumnName("IdExamenFisicoSP");
            entity.Property(e => e.IdTipoPatologiaCp).HasColumnName("IdTipoPatologiaCP");
            entity.Property(e => e.IdTipoPatologiaSp).HasColumnName("IdTipoPatologiaSP");
            entity.Property(e => e.UsuarioCrea).HasColumnName("Usuario_Crea");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07AA8D3ED3");

            entity.Property(e => e.Nvia)
                .IsUnicode(false)
                .HasColumnName("NVIA");
            entity.Property(e => e.Nvib)
                .IsUnicode(false)
                .HasColumnName("NVIB");
            entity.Property(e => e.TipoUsuario).HasColumnName("Tipo_Usuario");
            entity.Property(e => e.Usuario1).HasColumnName("Usuario");
            entity.Property(e => e.UsuarioSql)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UsuarioSQL");
        });

        modelBuilder.Entity<UsuarioPermiso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario___3214EC07D9544500");

            entity.ToTable("Usuario_Permisos");

            entity.Property(e => e.FechaSistema)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Sistema");
            entity.Property(e => e.HeredarPermiso)
                .HasDefaultValue(false)
                .HasColumnName("Heredar_Permiso");
            entity.Property(e => e.IdPermiso).HasColumnName("Id_Permiso");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

            entity.HasOne(d => d.IdPermisoNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdPermiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario_P__Id_Pe__7BE56230");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario_P__Id_Us__7AF13DF7");
        });

        modelBuilder.Entity<UsuariosWeb>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuarios__645723A66711A81C");

            entity.ToTable("usuariosWeb");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Clave)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.EsAsctivo)
                .HasDefaultValue(true)
                .HasColumnName("esAsctivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UsuariosWebs)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__usuariosW__idRol__2512604C");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ventas__3214EC0707E69493");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaHoraRegistro)
                .HasPrecision(0)
                .HasColumnName("FechaHora_Registro");
            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.NameClienteTem)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NumDoc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoVenta).HasColumnName("Tipo_Venta");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.VentaIdUsuarioNavigations)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Ventas__Id_Usuar__6F7F8B4B");

            entity.HasOne(d => d.MaquinaNavigation).WithMany(p => p.VentaMaquinaNavigations)
                .HasForeignKey(d => d.Maquina)
                .HasConstraintName("FK__Ventas__Maquina__6E8B6712");
        });

        modelBuilder.Entity<VentaPrecioEspecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Venta_Precio_Especial");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 4)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Estado).HasMaxLength(20);
            entity.Property(e => e.FechaAprueba).HasColumnType("datetime");
            entity.Property(e => e.FechaRechaza).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdDetVenta).HasColumnName("Id_Det_Venta");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.PrecioEspecial)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Precio_Especial");
            entity.Property(e => e.UsuarioAprueba).HasColumnName("Usuario_Aprueba");
            entity.Property(e => e.UsuarioRechaza).HasColumnName("Usuario_Rechaza");
            entity.Property(e => e.UsuarioSolicita).HasColumnName("Usuario_Solicita");
        });

        modelBuilder.Entity<VentasPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ventas_Pago");

            entity.Property(e => e.Adquirente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADQUIRENTE");
            entity.Property(e => e.ChequeMonto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cheque_Monto");
            entity.Property(e => e.IdBanco).HasColumnName("Id_Banco");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.ImagenCheque).HasColumnName("Imagen_Cheque");
            entity.Property(e => e.ImagenTranf).HasColumnName("Imagen_Tranf");
            entity.Property(e => e.MontoEfectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MontoTc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TC");
            entity.Property(e => e.MontoTd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_TD");
            entity.Property(e => e.MontoTranf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Monto_Tranf");
            entity.Property(e => e.TcInteres)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TC_Interes");
            entity.Property(e => e.TipoPago).HasColumnName("Tipo_Pago");
        });

        modelBuilder.Entity<VentasProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ventas_Productos", tb => tb.HasTrigger("trg_calcular_totales_vp"));

            entity.HasIndex(e => e.IdVenta, "IX_VentasProductosDetalle");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdCombo).HasColumnName("Id_Combo");
            entity.Property(e => e.IdPrecioEspecial).HasColumnName("Id_Precio_Especial");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubtotalCp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_CP");
            entity.Property(e => e.SubtotalDp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_DP");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
        });

        modelBuilder.Entity<VentasProductosTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ventas_Productos_Temp", tb => tb.HasTrigger("trg_calcular_totales"));

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ganancia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdCombo).HasColumnName("Id_Combo");
            entity.Property(e => e.IdPrecioEspecial).HasColumnName("Id_Precio_Especial");
            entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("Id_Venta");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.Parcial).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVP");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubtotalCp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_CP");
            entity.Property(e => e.SubtotalDp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Subtotal_DP");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.VencimientoTexto).HasColumnName("Vencimiento_Texto");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Venta__077D5614B95E8A12");

            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoPago");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
