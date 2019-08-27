using Rotativa;
using SeguroViagem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers
{
    public class ApoliceController : Controller
    {
        // GET: Apolice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dados(ViajanteViewModel viajante)
        {
            var Dados = viajante;
            return View(Dados);
        }
        public ActionResult Imprimir(ViajanteViewModel viajante)
        {
            var q = new ActionAsPdf("Dados");
            return q;
        }
    }
}