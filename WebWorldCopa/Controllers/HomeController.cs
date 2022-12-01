using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWorldCopa.Models;

namespace WebWorldCopa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Resultado()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Usuario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Usuario(Cadastro usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
    }
}