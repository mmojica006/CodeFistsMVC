using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webEFCodeFirst.Models
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string Nombre { get; set; }

        public TipoCliente Tipo { get; set; }

    }
}