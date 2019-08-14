using SeguroViagem.Business;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using SeguroViagem.DAO;

namespace SeguroViagem.Controllers
{
    public class CotacaoController : Controller
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();
        // GET: Cotacao
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Inserir()
        {
            var estado = new DropDownEstados();
            var model = new Cotacao()
            {
                EstadoLista = estado.GetAll()
            };
            return View("Inserir",model);
        }
        [HttpPost]
        public ActionResult Inserir(Cotacao cotacao)
        {
            //if (ModelState.IsValid)
            //{
                //var frigorifico = Mapper.Map<FrigorificoViewModel, Frigorifico>(frigorificoViewModel);
                var dao = new CotacaoDAO();
                dao.Adicionar(cotacao);
                return RedirectToAction("Inserir", "Cotacao");
            //}
            //else
            //{
            //    return RedirectToAction("Inserir");
            //}
        }
    }
}