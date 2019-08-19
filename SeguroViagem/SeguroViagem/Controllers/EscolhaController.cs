using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeguroViagem.Business;
using SeguroViagem.DAO;
using SeguroViagem.Models;

namespace SeguroViagem.Controllers
{
    public class EscolhaController : Controller
    {
        // GET: Escolha
        private SeguroViagemContexto db = new SeguroViagemContexto();

        // GET: Escolha
        public ActionResult Index(Cotacao cotacao)
        {
            var seguradoras = new CalculaValor().CalculaValorCotacao(cotacao);


            return View(seguradoras);
        }
    }
}