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

        [HttpGet]
        public ActionResult Inserir()
        {
            var estado = new DropDownEstados(); // Estanciei a classe dropwodnestados
            var model = new Cotacao()

            {
                EstadoLista = estado.GetAll(), 

            };
            return View("Inserir", model);
        }
        [HttpPost]
        public ActionResult Inserir(Cotacao cotacao)
        {
            if (ModelState.IsValid)
            {
                var dao = new CotacaoDAO();
                cotacao.QtdeDias = Cotacao.Duracao(cotacao.Ida, cotacao.Volta);
                dao.Adicionar(cotacao);
                return RedirectToAction("Index", "Escolha", new { idCotacao = cotacao.CotId });
            }
            else
            {
                var estado = new DropDownEstados();
                cotacao.EstadoLista = estado.GetAll(); // recarregar a página com a lista dos estados

                return View("Inserir", cotacao);
            }
        }

        public ActionResult Listar()
        {
            var dao = new CotacaoDAO();
            var cotacao = dao.Lista();
            return View(cotacao);
        }

        public ActionResult Visualizar(int id)
        {
            var dao = new CotacaoDAO();
            Cotacao cotacao = dao.BuscarPorId(id);
            return View(cotacao);
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            var dao = new CotacaoDAO();
            Cotacao cotacao = dao.BuscarPorId(id);
            return View(cotacao);
        }

        [HttpPost]
        public ActionResult Atualizar(Cotacao cotacao)
        {
            if (ModelState.IsValid)
            {
                var dao = new CotacaoDAO();
                dao.Atualizar(cotacao);
                return RedirectToAction("Listar");
            }
            else
            {
                return View("Atualizar");
            }
        }

        [HttpGet]
        public ActionResult Remover(int id)
        {
            var dao = new CotacaoDAO();
            Cotacao cotacao = dao.BuscarPorId(id);
            return View(cotacao);
        }
        [HttpPost]
        public ActionResult Remover(Cotacao cotacao)
        {
            var dao = new CotacaoDAO();
            dao.Remover(cotacao);
            return RedirectToAction("Listar");
        }

    }
}