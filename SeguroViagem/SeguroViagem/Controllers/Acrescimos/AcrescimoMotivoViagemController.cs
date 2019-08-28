using SeguroViagem.DAO.Acréscimos;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers.Acrescimos
{
    public class AcrescimoMotivoViagemController : Controller
    {
        // GET: AcrescimoMotivoViagem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inserir()
        {
            return View();
        }
        public ActionResult Listar()
        {
            var dao = new AcrescimoMotivoViagemDAO();
            var acrescimo = dao.Lista();
            return View(acrescimo);
        }
        public ActionResult Visualizar(int id)
        {
            var dao = new AcrescimoMotivoViagemDAO();
            AcrescimoMotivoViagem acrescimo = dao.BuscaPorId(id);
            return View(acrescimo);
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            var dao = new AcrescimoMotivoViagemDAO();
            AcrescimoMotivoViagem acrescimo = dao.BuscaPorId(id);
            return View(acrescimo);
        }
        [HttpPost]
        public ActionResult Atualizar(AcrescimoMotivoViagem acrescimoMotivoViagem)
        {
            if (ModelState.IsValid)
            {
                var dao = new AcrescimoMotivoViagemDAO();
                dao.Atualizar(acrescimoMotivoViagem);
                return RedirectToAction("Listar");
            }
            return View("Atualizar");
        }

        //[HttpGet]
        //public ActionResult Remover(int id)
        //{
        //    var dao = new AcrescimoMotivoViagemDAO();
        //    AcrescimoMotivoViagem acrescimo = dao.BuscaPorId(id);
        //    return View(acrescimo);
        //}
        //[HttpPost]
        //public ActionResult Remover(AcrescimoMotivoViagem acrescimoMotivoViagem)
        //{
        //    var dao = new AcrescimoMotivoViagemDAO();
        //    dao.Remover(acrescimoMotivoViagem);
        //    return RedirectToAction("Listar");
        //}
    }
}