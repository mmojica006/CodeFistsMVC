using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webEFCodeFirst.Models
{
    public class contextoAplicacion: DbContext
    {
        public contextoAplicacion():base("name=DefaultConnectionString")
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<contextoAplicacion, Migrations.Configuration>("DefaultConnectionString"));
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoCliente> Tipos { get; set; }

    }
}