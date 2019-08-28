using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost] //defidino como POST e não como GET
        public ActionResult Autherize(SeguroViagem.Models.User userModel)
        {
            using (SeguroViagemContexto db = new SeguroViagemContexto())
            {

                // setei meu x.userName para o nome de user q escreve e setei meu x.password para a senha q ele digitar.
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                // validação dos meus campos
                if (userDetails == null)
                {
                    // Se você errar o login e senha, aparece a mensagem.
                    userModel.LoginErrorMessage = "Usuário ou senha estão incorretos.";
                    return View("Index", userModel);
                }
                else
                {
                    Session["UserID"] = userDetails.UserID;
                    // Se você quiser mostrar o nome na sua pagina (dashboard).
                    Session["UserName"] = userDetails.UserName;
                    // Se login e senha correto você é redirecionado para action , controler
                    return RedirectToAction("Listar", "Seguradora");
                }
            }
        }

        public ActionResult LogOut()
        {

            int userId = (int)Session["UserID"]; // N entendi pq criou isso.
            //Logout
            Session.Abandon();
            //(action,controler)
            return RedirectToAction("Inserir", "Cotacao");
        }

    }
}