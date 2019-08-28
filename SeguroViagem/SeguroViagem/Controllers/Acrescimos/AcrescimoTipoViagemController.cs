using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers.Acrescimos
{
    public class AcrescimoTipoViagemController : Controller
    {
        SeguroViagemContexto db = new SeguroViagemContexto();
        // GET: AcrescimoTipoViagem
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
            var dao = new AcrescimoTipoViagemDAO();
            var acrescimo = dao.Lista();
            return View(acrescimo);
        }
        public ActionResult Visualizar(int id)
        {
            var dao = new AcrescimoTipoViagemDAO();
            AcrescimoTipoViagem acrescimo = dao.BuscaPorId(id);
            return View(acrescimo);
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            var dao = new AcrescimoTipoViagemDAO();
            var acrescimo = dao.BuscaPorId(id);
            return View(acrescimo);
        }
        [HttpPost]
        public ActionResult Atualizar(AcrescimoTipoViagem acrescimoTipoViagem)
        {
            if (ModelState.IsValid)
            {
                var dao = new AcrescimoTipoViagemDAO();
                dao.Atualizar(acrescimoTipoViagem);
                return RedirectToAction("Listar");
            }
            return View("Atualizar");
        }

        //[HttpGet]
        //public ActionResult Remover(int id)
        //{
        //    var dao = new AcrescimoTipoViagemDAO();
        //    AcrescimoTipoViagem acrescimo = dao.BuscaPorId(id);
        //    return View(acrescimo);
        //}
        //[HttpPost]
        //public ActionResult Remover(AcrescimoTipoViagem acrescimoTipoViagem)
        //{
        //    var dao = new AcrescimoTipoViagemDAO();
        //    dao.Remover(acrescimoTipoViagem);
        //    return RedirectToAction("Listar");
        //}
    }
}