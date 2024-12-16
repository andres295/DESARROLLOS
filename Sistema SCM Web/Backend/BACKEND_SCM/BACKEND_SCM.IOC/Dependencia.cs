using BACKEND_SCM.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_SCM.DAL.Repositorios;
using BACKEND_SCM.DAL.Repositorios.Contrato;
using BACKEND_SCM.UTILITY;
using BACKEND_SCM.BLL.Servicios.Contrato;
using BACKEND_SCM.BLL.Servicios;


namespace BACKEND_SCM.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ScmContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("cadenaSQL"));
            
            } );
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository,VentaRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            //Agregar todos los servicios
            services.AddScoped<IComposicionQuimicaService, ComposicionQuimicaService>();
            services.AddScoped<IDashBoardService, DashBoardService>();
            services.AddScoped<IEspecificacionesService, EspecificacionesService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IPresentacionService, PresentacionService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IProveedoresService, ProveedoresService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IVentaService, VentaService>();

        }
    }
}
