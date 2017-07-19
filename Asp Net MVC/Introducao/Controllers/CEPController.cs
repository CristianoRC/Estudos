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
            var enderecoEx = Consultas.ObterEnderecoCompleto("96083-500");

            return View(enderecoEx);
        }
    }
}
