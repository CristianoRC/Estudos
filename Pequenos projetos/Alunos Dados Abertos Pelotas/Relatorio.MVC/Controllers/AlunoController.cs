using Microsoft.AspNetCore.Mvc;
using Relatorio;

namespace RelatorioAlunos.MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index(RepositorioAluno repositorioAluno, RepositorioEscola repositorioEscola)
        {
            ViewData["formandos"] = repositorioAluno.ObterNumeroDeAlunosFormandos();
            ViewData["total"] = repositorioAluno.ObterNumeroDeAlunos();
            ViewData["homem"] = repositorioAluno.ObterNumeroDeAlunosSexo(ESexo.Masculino);
            ViewData["mulher"] = repositorioAluno.ObterNumeroDeAlunosSexo(ESexo.Feminino);
            ViewData["escolas"] = repositorioEscola.ObterNumeroDeEscolas();
            ViewData["AlunosComNecessidades"] = repositorioAluno.ObterNumeroDeAlunosComNecessidades();

            return View();
        }

        [Route("Aluno/Pesquisa")]
        public IActionResult Pesquisa([FromQuery]int matricula, RepositorioAluno repositorio)
        {
            return View("Informacoes", repositorio.Buscar(matricula));
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}