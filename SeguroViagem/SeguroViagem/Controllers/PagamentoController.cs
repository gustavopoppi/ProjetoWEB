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

        
        public ActionResult Index(PagamentoViewModel pagamentoViewModel)
        {
            if (ModelState.IsValid)
            {                
                return Json(new { formValido = true }); 
            }
            return PartialView("Index", pagamentoViewModel);
        }
        //public ActionResult Dados(ImpressaoViewModel impressaoViewModel)
        //{
        //    return View(impressaoViewModel);
        //}
        public ActionResult Imprimir(PagamentoViewModel pagamentoViewModel)
        {
            var impressaoViewModel = new GeradorApolice().GerarApolice(pagamentoViewModel);

            var relatorioPDF = new ViewAsPdf
            {
                ViewName = "Dados",
                IsGrayScale = true,
                Model = impressaoViewModel
            };
            return relatorioPDF;
        }
    }
}