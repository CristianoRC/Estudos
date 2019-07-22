using Microsoft.AspNetCore.Mvc;

namespace GerarImagem.Controllers
{
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult OlaMundo()
        {
            return Ok(new { Valor = "Olá Mundo!" });
        }
    }
}