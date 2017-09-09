using System.Web.Mvc;
using Automacao.Models;

namespace Automacao.Controllers
{  
    public class LampadaController : Controller
    {
        private Lampada Led = new Lampada();
        
        public ActionResult Ligada()
        {
            Led.Ligar();
            return View();
        }

        public ActionResult Desligada()
        {
            Led.Ligar();
            return View();
        }
    }
}