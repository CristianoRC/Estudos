using System;
using System.ComponentModel.DataAnnotations;

namespace Servidor
{
    public class Pedido
    {
        public Pedido(string nomeDoCliente, string descricao)
        {
            this.Id = Guid.NewGuid();
            this.NomeDoCliente = nomeDoCliente;
            this.Descricao = descricao;
            this.DataDeEntrada = DateTimeOffset.UtcNow;
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Inisra o nome do cliente")]
        public string NomeDoCliente { get; set; }
        [Required(ErrorMessage = "Inisra a descrição do pedido")]
        public string Descricao { get; set; }

        public DateTimeOffset DataDeEntrada { get; set; }
    }
}