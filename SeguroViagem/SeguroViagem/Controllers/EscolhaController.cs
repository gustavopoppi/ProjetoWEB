using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeguroViagem.Business;
using SeguroViagem.DAO;
using SeguroViagem.Models;
using SeguroViagem.Models.Seguranca;
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
        public ActionResult Prosseguir(DadosViajante dadosViajante)
        {


            if (dadosViajante.CPF != null )
            {
                if (!ValidacaoCPF.Validar(dadosViajante.CPF))
                    ModelState.AddModelError("InvalidCPF", "CPF Inválido ");
            }
            if (dadosViajante.CPF == null)
            {
                ModelState.AddModelError("InvalidCPF", "Campo Obrigatório");
            }


            dadosViajante.Profissao = "nulo";
            if (ModelState.IsValid)
            {
                var dao = new DadosViajanteDAO();
                dao.Adicionar(dadosViajante);

                return Json(new { formValido = true, viajanteId = dadosViajante.ViajanteId });
            }
            return PartialView("Viajante", dadosViajante);

        }
        [HttpPost]
        public ActionResult Inserir(Seguradora seguradoras)
        {
            if (ModelState.IsValid)
            {
                var dao = new SeguradoraDAO();
                dao.Adicionar(seguradoras);
                return RedirectToAction("Listar");
            }
            else
            {
                return View("Inserir");
            }
        }
    }
}