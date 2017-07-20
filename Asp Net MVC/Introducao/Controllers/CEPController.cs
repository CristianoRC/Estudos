using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotCEP;
using Introducao.Models;

namespace Introducao.Controllers
{
    public class CEPController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Index(string CEP)
        {
            var enderecoEx = Consultas.ObterEnderecoCompleto(CEP);

            return View(enderecoEx);
        }
    }
}