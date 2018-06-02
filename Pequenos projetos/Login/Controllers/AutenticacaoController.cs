using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Autenticacao.Models;

namespace Autenticacao.Controllers
{
    public class AutenticacaoController : Controller
    {
        public IActionResult Login([FromForm]string email, [FromForm]string senha, PessoaRepositorio repositorio)
        {
            if (email != null && senha != null)
            {
                var pessoaTemp = new Pessoa(email, senha);

                if (pessoaTemp.Logar(repositorio))
                {
                    return RedirectToAction("Administrativo");
                }
                else
                {
                    ViewBag.email = email;
                }
            }
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Administrativo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]string nome, [FromForm]string email, [FromForm]string senha, PessoaRepositorio repositorio)
        {
            var pessoaTemp = new Pessoa(nome, email, senha);
            repositorio.Cadastrar(pessoaTemp);

            return View("Login");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
