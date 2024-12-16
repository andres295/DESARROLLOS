using ApiInv.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInv.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Inventa> Inventa { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Ubicaciones> Ubicaciones { get; set; }

    }
}
