using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Controllers
{
    public class HomeController : Controller
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();

        public ActionResult Index()
        {
            return View(/*db.Estados.ToList()*/);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}