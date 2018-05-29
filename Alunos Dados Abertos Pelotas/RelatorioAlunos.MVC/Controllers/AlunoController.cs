using Microsoft.AspNetCore.Mvc;

namespace RelatorioAlunos.MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index(RepositoioAluno repositorio)
        {
            ViewData["formandos"] = repositorio.ObterNumeroDeAlunosFormandos();
            ViewData["total"] = repositorio.ObterNumeroDeAlunos();
            ViewData["homem"] = repositorio.ObterNumeroDeAlunosSexo(ESexo.Masculino);
            ViewData["mulher"] = repositorio.ObterNumeroDeAlunosSexo(ESexo.Feminino);
            ViewData["outro"] = repositorio.ObterNumeroDeAlunosSexo(ESexo.Outro);
            ViewData["AlunosComNecessidades"] = repositorio.ObterNumeroDeAlunosComNecessidades();

            return View();
        }

        [Route("Aluno/Pesquisa")]
        public IActionResult Pesquisa([FromQuery]int matricula, RepositoioAluno repositorio)
        {
            return View("Informacoes", repositorio.Buscar(matricula));
        }

        public IActionResult Sobre()
        {
            return View();
        }
    }
}