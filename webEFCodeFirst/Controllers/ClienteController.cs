using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webEFCodeFirst.Models;

namespace webEFCodeFirst.Controllers
{
    public class ClienteController : Controller
    {
       private  contextoAplicacion db = new contextoAplicacion();
        // GET: Cliente
        public ActionResult Index()
        {
            var consulta = from c in db.Clientes
                           select new
                           {
                               id = c.clienteId,
                               Mombrecliente = c.Nombre,
                               Tipo = c.Tipo.NombreTipo

                           };

            return Json(consulta.ToList(), JsonRequestBehavior.AllowGet);
        }

        public string Crear(int idTipo, string nombreCliente)
        {
            if ( nombreCliente != null)
            {
                var tipoCliente = db.Tipos.Find(idTipo);

                if (tipoCliente != null)
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = nombreCliente;
                    cliente.Tipo = tipoCliente;
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    return "El registro se ha agregado";

                }else
                {
                    return "El tipo de cliente no se encontro";
                }

            }else
            {
                return "No se proporciono el nombre del cliente";
            }

        }
    }
}