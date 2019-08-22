using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers
{

    public class SeguradoraController : Controller
    {
        SeguroViagemContexto db = new SeguroViagemContexto();
        //public ActionResult Index()
        //{
        //    return View(db.Seguradoras.ToList());
        //}

        [HttpGet]
        public ActionResult Inserir()
        {
            // Inicializo as listas que criei no model
            var model = new Seguradora();
            return View(model);
        }
        [HttpPost]
        public ActionResult Inserir(Seguradora seguradoras)
        {
            if (ModelState.IsValid)
            {
                //var seguradora = Mapper.Map<FazendaViewModel, Fazenda>(fazendaViewModel);
                var dao = new SeguradoraDAO();
                dao.Adicionar(seguradoras);
                return RedirectToAction("Listar");
            }
            else
            {
                return View("Inserir");
            }
        }

        public ActionResult Listar()
        {
            var dao = new SeguradoraDAO();
            var seguradoras = dao.Lista();
            //var fazendasViewModel = Mapper.Map<IList<Fazenda>, IList<FazendaViewModel>>(fazendas);
            return View(seguradoras);
        }

        //public ActionResult Visualizar(int id)
        //{
        //    var dao = new SeguradoraDAO();
        //    Seguradoras fazenda = dao.BuscarPorId(id);
        //    //var fazendaViewModel = Mapper.Map<Fazenda, FazendaViewModel>(fazenda);
        //    return View(Seguradoras);
        //}

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            var dao = new SeguradoraDAO();
            Seguradora seguradoras = dao.BuscarPorId(id);
            //var fazendaViewModel = Mapper.Map<Fazenda, FazendaViewModel>(fazenda);
            return View(seguradoras);
        }

        [HttpPost]
        public ActionResult Atualizar(Seguradora seguradoras)
        {
            if (ModelState.IsValid)
            {
                var dao = new SeguradoraDAO();
                //var fazenda = Mapper.Map<FazendaViewModel, Fazenda>(fazendaViewModel);
                dao.Atualizar(seguradoras);
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
            var dao = new SeguradoraDAO();
            Seguradora seguradoras = dao.BuscarPorId(id);
            //var fazendaViewModel = Mapper.Map<Fazenda, FazendaViewModel>(fazenda);
            return View(seguradoras);
        }

        [HttpPost]
        public ActionResult Remover(Seguradora seguradoras)
        {
            var dao = new SeguradoraDAO();
            //var fazenda = Mapper.Map<FazendaViewModel, Fazenda>(fazendaViewModel);
            dao.Remover(seguradoras);
            return RedirectToAction("Listar");
        }

    }
}