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
        // GET: Pagamento
        public ActionResult Index(ViajanteViewModel viajante)
        {
            if (ModelState.IsValid)
            {
                return Json(new { formValido = true }); // aqui virá a impressão da apólice
            }
            return PartialView("~/Pagamento/Index", viajante.Pagamento);
        }
    }
}