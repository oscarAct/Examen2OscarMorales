using Examen2OscarMorales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen2OscarMorales.Controllers
{
    public class ConsultasController : Controller
    {
        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Datos()
        {
            ConsultasModel modelo = new ConsultasModel();
            var results = modelo.TraerDatos();
            return Json(results);
        }
        [HttpPost]
        public JsonResult Buscar(String seller)
        {
            ConsultasModel modelo = new ConsultasModel();
            var results = modelo.Buscar(seller);
            return Json(results);
        }

    }
}