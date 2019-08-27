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
        public ActionResult Imprimir()
        {
            return View();
        }
    }
}