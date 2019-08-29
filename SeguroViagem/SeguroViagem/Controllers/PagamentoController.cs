using Rotativa;
using SeguroViagem.Business;
using SeguroViagem.DAO;
using SeguroViagem.Models;
using SeguroViagem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers
{
    public class PagamentoController : Controller
    {
        //private SeguroViagemContexto db = new SeguroViagemContexto();

        // GET: Pagamento
        public ActionResult Index(PagamentoViewModel pagamentoViewModel)
        {
            if (ModelState.IsValid)
            {                
                return Json(new { formValido = true }); // aqui virá a impressão da apólice
                return RedirectToAction("Imprimir", pagamentoViewModel);
            }
            return PartialView("Index", pagamentoViewModel/*.Pagamento*/);
        }
        public ActionResult Dados(ImpressaoViewModel impressaoViewModel)
        {
            return View(impressaoViewModel);
        }
        public ActionResult Imprimir(PagamentoViewModel pagamentoViewModel)
        {
            var impressaoViewModel = new GeradorApolice().GerarApolice(pagamentoViewModel);
            var q = new ActionAsPdf("Dados", impressaoViewModel);
            return q;
        }
    }
}