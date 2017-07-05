using DropDownCascata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownCascata.Controllers
{
    public class EstadoController : Controller
    {
        Contexto db = new Contexto();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObterEstados()
        {
            var estados = db.Estados.ToList();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(estados, "EstadoId", "Sigla")
                    , JsonRequestBehavior.AllowGet);
            }

            return View(estados);

        }

        public ActionResult ObterCidades(int id)
        {
            var cidades = db.Cidades.Where(e => e.EstadoId == id).ToList();

            if (HttpContext.Request.IsAjaxRequest()) {

                return Json(new SelectList(cidades, "CidadeId", "Descricao")
                    , JsonRequestBehavior.AllowGet);
            }

            return View(cidades);

        }
    }
}