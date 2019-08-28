using SeguroViagem.DAO.Acréscimos;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers.Acrescimos
{
    public class AcrescimoMeioTransporteController : Controller
    {
        // GET: AcrescimoMeioTransporte
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var dao = new AcrescimoMeioTransporteDAO();
            var acrescimo = dao.Lista();
            return View(acrescimo);
        }

        public ActionResult Visualizar(int id)
        {
            var dao = new AcrescimoMeioTransporteDAO();
            AcrescimoMeioTransporte acrescimo = dao.BuscarPorId(id);
            return View(acrescimo);
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            var dao = new AcrescimoMeioTransporteDAO();
            AcrescimoMeioTransporte acrescimo = dao.BuscarPorId(id);
            return View(acrescimo);
        }
        [HttpPost]
        public ActionResult Atualizar(AcrescimoMeioTransporte acrescimoMeioTransporte)
        {
            if (ModelState.IsValid)
            {
                var dao = new AcrescimoMeioTransporteDAO();
                dao.Atualizar(acrescimoMeioTransporte);
                return RedirectToAction("Listar");
            }
            return View("Atualizar");
        }

        [HttpGet]
        public ActionResult Remover(int id)
        {
            var dao = new AcrescimoMeioTransporteDAO();
            AcrescimoMeioTransporte acrescimo = dao.BuscarPorId(id);
            return View(acrescimo);
        }
        [HttpPost]
        public ActionResult Remover(AcrescimoMeioTransporte acrescimoMeioTransporte)
        {
            var dao = new AcrescimoMeioTransporteDAO();
            dao.Remover(acrescimoMeioTransporte);
            return RedirectToAction("Listar");
        }
    }
}