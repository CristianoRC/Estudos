using System.Web.Mvc;
using DotCEP;

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