using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webEFCodeFirst.Models;

namespace webEFCodeFirst.Controllers
{
    public class TipoClienteController : Controller
    {
       private  contextoAplicacion dbContext = new contextoAplicacion();

        // GET: TipoCliente
        public ActionResult Index()
        {
            return Json(dbContext.Tipos.ToList(),JsonRequestBehavior.AllowGet);
        }
        public string Crear(string nombreTipo)
        {

            if (nombreTipo != null)
            {
                TipoCliente tipoCliente = new TipoCliente();
                tipoCliente.NombreTipo = nombreTipo;
                dbContext.Tipos.Add(tipoCliente);
                dbContext.SaveChanges();

                return "Se agrgo el registro de manera correcta";


            }else
            {
                return "El nombre del tipo no es correcto";
            }


        }

        public string Modificar (int id, string nombreTipo)
        {
            if (nombreTipo != null)
            {
                TipoCliente tipocliente = dbContext.Tipos.Find(id);
                if (tipocliente != null)
                {
                    tipocliente.NombreTipo = nombreTipo;
                    dbContext.Entry(tipocliente).State = EntityState.Modified;
                    dbContext.SaveChanges();

                    return ("El registro se modifico correctamente");


                }else
                {
                    return ("El tipo no se encuentra");
                }

            }else
            {
                return "No se espeficico de manera correcta";
            }

        }

        public string Eliminar(int id)
        {
            TipoCliente tipocliente = dbContext.Tipos.Find(id);

            if (tipocliente != null)
            {
                dbContext.Tipos.Remove(tipocliente);
                dbContext.SaveChanges();
                return "El registro se ha eliminado correctamente";
            }else
            {
                return "El tipo indicado no se encuentra";
            }

        } 

    }
}