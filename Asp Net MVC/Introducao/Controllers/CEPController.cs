using System.Web.Mvc;
using DotCEP;
using System;

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

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Enderecos()
        {
            var listaDeEnderecos = Consultas.ObterListaDeEnderecos(UF.RS, "Pelotas", "Ferreira");
            return View(listaDeEnderecos);
        }
    }
}