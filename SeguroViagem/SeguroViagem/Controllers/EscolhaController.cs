using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeguroViagem.Business;
using SeguroViagem.DAO;
using SeguroViagem.Models;
using SeguroViagem.ViewModel;

namespace SeguroViagem.Controllers
{
    public class EscolhaController : Controller
    {
        // GET: Escolha
        public ActionResult Index(int idCotacao)
        {

            var seguradoras = new CalculaValor().CalculaValorCotacao(idCotacao);

            return View(seguradoras);
        }
        public ActionResult Prosseguir(ViajanteViewModel viajante)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Pagamento", "Index", new { viajanteViewModel = viajante });
            }
            return PartialView("Viajante", viajante);
        }
    }
}