using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contato.Models;

namespace Contato.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Mensagem mensagem, MensagemRepositorio repositorio)
        {
            repositorio.Cadastrar(mensagem);
            var resposta = $"Olá {mensagem.Nome}, sua mensagem foi enviada com sucesso. Entraremos em contato o mais rápido possível.";

            return View("Resultado", resposta);
        }

        public IActionResult Administrativo(MensagemRepositorio repositorio)
        {
            return View(repositorio.Listar());
        }

        public IActionResult Informacoes([FromRoute]string Id, MensagemRepositorio repositorio)
        {
            Id = Id.Replace("%2F", "/");
            return View(repositorio.Buscar(Id));
        }

        public IActionResult Deletar(string Id, MensagemRepositorio repositorio)
        {
            Id = Id.Replace("%2F", "/");
            repositorio.Deletar(Id);
            return View("Resultado", $"A Mensagem \'{Id}\' foi deletada com sucesso!");
        }

        [HttpPut]
        [Route("Home/AtualizarStatus/{Colecao}/{Id}/{Status}")]
        public IActionResult AtualizarStatus([FromRoute] string Colecao, [FromRoute]string Id, [FromRoute]bool Status, MensagemRepositorio repositorio)
        {
            Id = $"{Colecao}/{Id}";
            repositorio.AtualizarStatusVerificada(Id, Status);
            return StatusCode(204);
        }
    }
}
