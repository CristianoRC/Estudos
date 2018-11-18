using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Servidor;

namespace Servidor.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly PedidoRepository _repository;

        public PedidoController()
        {
            _repository = new PedidoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pedido = _repository.RemoverDaFila();
            return Ok(pedido);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            _repository.AdicionarNaFila(pedido);
            return Ok(pedido);
        }
    }
}