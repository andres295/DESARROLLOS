using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BACKEND_SCM.DTO;
using BACKEND_SCM.MODEL;

namespace BACKEND_SCM.UTILITY
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Rol
            CreateMap<Rol, RolDTO>().ReverseMap();
            #endregion Rol

            #region Menu
            CreateMap<Menu, MenuDTO>().ReverseMap();
            #endregion Menu

            #region Usuario
            CreateMap<UsuariosWeb, UsuarioDTO>()
                .ForMember(destino =>
                destino.RolDescripcion,
                opt => opt.MapFrom(origen => origen.IdRolNavigation.Nombre)
                )
                .ForMember(destino =>
                destino.EsAsctivo,
                opt => opt.MapFrom(
                    origen => origen.EsAsctivo == true ? 1 : 0)
                );
            CreateMap<UsuariosWeb, SesionDTO>()
                .ForMember(destino =>
                destino.RolDescripcion,
                opt => opt.MapFrom(origen => origen.IdRolNavigation.Nombre)
                );
            CreateMap<UsuarioDTO, UsuariosWeb>()
               .ForMember(destino =>
               destino.IdRolNavigation,
               opt => opt.Ignore()
               )
                .ForMember(destino =>
               destino.EsAsctivo,
               opt => opt.MapFrom(
                   origen => origen.EsAsctivo == 1 ? true : false)
               );
            #endregion Usuario

            #region Especificaciones
            CreateMap<Especificacione, EspecificacionesDTO>().ReverseMap();
            #endregion Especificaciones

            #region Presentaciones
            CreateMap<Presentacione, PresentacionDTO>().ReverseMap();
            #endregion Presentaciones

            #region Proveedores
            CreateMap<Proveedore, ProveedoresDTO>().ReverseMap();
            #endregion Proveedores

            #region Productos
            CreateMap<Producto, ProductoDTO>()
                .ForMember(destino =>
                destino.DescripcionEspecifiacion,
                opt => opt.MapFrom(origen => origen.IdEspecificacionNavigation.Especificacion)
                )
                .ForMember(destino =>
                destino.DescripcionPresentacion,
                opt => opt.MapFrom(origen => origen.IdPresentacionNavigation.Presentacion)
                )
                .ForMember(destino =>
                destino.NombreProveedor,
                opt => opt.MapFrom(origen => origen.IdProveedorNavigation.Proveedor)
                )
                .ForMember(destino =>
                destino.Pvp,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Pvp.Value, new CultureInfo("es-419")))
                )
                 .ForMember(destino =>
                destino.Pvf,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Pvf.Value, new CultureInfo("es-419")))
                );

            /*
                            .ForMember(destino =>
                            destino.Producto1,
                            opt => opt.MapFrom(origen => origen.Producto1)
                            )

                            .ForMember(destino =>
                            destino.Estado,
                            opt => opt.MapFrom(origen => origen.Estado)
                            )
                              .ForMember(destino =>
                            destino.CodigoBarra,
                            opt => opt.MapFrom(origen => origen.CodigoBarra)
                            )
                                .ForMember(destino =>
                            destino.Producto1,
                            opt => opt.MapFrom(origen => origen.Producto1)
                            )
                           .ForMember(destino =>
                            destino.Contiene,
                            opt => opt.MapFrom(origen => origen.Contiene)
                            )
                             .ForMember(destino =>
                            destino.Producto1,
                            opt => opt.MapFrom(origen => origen.Producto1)
                            )
                                .ForMember(destino =>
                            destino.Disponible,
                            opt => opt.MapFrom(origen => origen.Disponible)
                            )
                           .ForMember(destino =>
                            destino.RegistroSanitario,
                            opt => opt.MapFrom(origen => origen.RegistroSanitario)
                            );
            */
            //Revertir
            CreateMap<ProductoDTO, Producto>()
            .ForMember(destino =>
            destino.IdEspecificacionNavigation,
            opt => opt.Ignore()
            )
            .ForMember(destino =>
            destino.IdPresentacionNavigation,
            opt => opt.Ignore()
            )
            .ForMember(destino =>
            destino.IdPresentacionNavigation,
            opt => opt.Ignore()
            )
            .ForMember(destino =>
            destino.Pvp,
            opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Pvp, new CultureInfo("es-419")))
            )
             .ForMember(destino =>
            destino.Pvf,
            opt => opt.MapFrom(origen => Convert.ToDecimal(origen.Pvf, new CultureInfo("es-419")))
            );
      
 /*
    .ForMember(destino =>
    destino.Producto1,
    opt => opt.MapFrom(origen => origen.Producto1)
    )
    .ForMember(destino =>
    destino.Estado,
    opt => opt.MapFrom(origen => origen.Estado)
    )
      .ForMember(destino =>
    destino.CodigoBarra,
    opt => opt.MapFrom(origen => origen.CodigoBarra)
    )
        .ForMember(destino =>
    destino.Producto1,
    opt => opt.MapFrom(origen => origen.Producto1)
    )
   .ForMember(destino =>
    destino.Contiene,
    opt => opt.MapFrom(origen => origen.Contiene)
    )
     .ForMember(destino =>
    destino.Producto1,
    opt => opt.MapFrom(origen => origen.Producto1)
    )
        .ForMember(destino =>
    destino.Disponible,
    opt => opt.MapFrom(origen => origen.Disponible)
    )
   .ForMember(destino =>
    destino.RegistroSanitario,
    opt => opt.MapFrom(origen => origen.RegistroSanitario)
    );  */
            #endregion Productos

            #region Venta
            CreateMap<Ventum, VentaDTO>()
                .ForMember(destino =>
                destino.TotalTexto,
                opt => opt.MapFrom(origen =>
               Convert.ToString(origen.Total.Value, new CultureInfo("es-419")))
                )
                  .ForMember(destino =>
                destino.FechaRegistro,
                opt => opt.MapFrom(origen => origen.FechaRegistro.Value.ToString("dd/MM/yyyy"))
                );

            CreateMap<VentaDTO, Ventum>()
                   .ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen =>
               Convert.ToDecimal(origen.TotalTexto, new CultureInfo("es-419")))
                );

            #endregion Venta

            #region DetalleVenta
            CreateMap<IdDetalleVentum, DetalleVentaDTO>()
                .ForMember(destino => destino.DescripcionProducto,
                opt => opt.MapFrom(origen => origen.IdProductoNavigation.Producto1)
                )
                  .ForMember(destino =>
                destino.PrecioTexto,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Precio.Value, new CultureInfo("es-419")))
                )
                         .ForMember(destino =>
                destino.TotalTexto,
                opt => opt.MapFrom(origen => Convert.ToString(origen.Total.Value, new CultureInfo("es-419")))
                );

            CreateMap<DetalleVentaDTO, IdDetalleVentum>()
           .ForMember(destino =>
            destino.Precio,
            opt => opt.MapFrom(origen => Convert.ToDecimal(origen.PrecioTexto, new CultureInfo("es-419")))
            )
               .ForMember(destino =>
            destino.Total,
            opt => opt.MapFrom(origen => Convert.ToDecimal(origen.TotalTexto, new CultureInfo("es-419")))
            );
            #endregion DetalleVenta

            #region Reporte
            CreateMap<IdDetalleVentum, ReporteDTO>()
                    .ForMember(destino =>
                destino.FechaRegistro,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.FechaRegistro.Value.ToString("dd/MM/yyyy"))
                )
                           .ForMember(destino =>
                destino.NumeroDocumento,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.NumeroDocumento)
                )
                   .ForMember(destino =>
                destino.TipoPago,
                opt => opt.MapFrom(origen => origen.IdVentaNavigation.TipoPago)
                )
                       .ForMember(destino =>
                destino.TotalVenta,
                opt => opt.MapFrom(origen =>
               Convert.ToString(origen.IdVentaNavigation.Total.Value, new CultureInfo("es-419")))
                )
                            .ForMember(destino =>
                destino.Producto,
                opt => opt.MapFrom(origen => origen.IdProductoNavigation.Producto1)
                )
                                   .ForMember(destino =>
                destino.Precio,
                opt => opt.MapFrom(origen =>
               Convert.ToString(origen.Precio.Value, new CultureInfo("es-419")))
                )
              .ForMember(destino =>
                destino.Total,
                opt => opt.MapFrom(origen =>
               Convert.ToString(origen.Total.Value, new CultureInfo("es-419")))
                );



            #endregion Reporte
        }
    }
}
