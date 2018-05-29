using Microsoft.AspNetCore.Mvc;
using Relatorio;

namespace RelatorioAlunos.MVC.Controllers
{
    public class EscolaController : Controller
    {
        public IActionResult Index(RepositorioEscola repositorio)
        {
            return View(repositorio.Listar());
        }

        public IActionResult Informacoes([FromQuery]string Escola, RepositorioEscola repositorio)
        {
            return View(repositorio.Buscar(Escola));
        }
    }
}