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

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoCliente> Tipos { get; set; }

    }
}