using System.Text;
using RabbitMQ.Client;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;

namespace Servidor
{
    public class PedidoRepository
    {
        public void AdicionarNaFila(Pedido pedido)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "testes",
                Password = "Testes2018!"
            };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("Pedidos", true, false, false, null);

                    var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(pedido));

                    channel.BasicPublish(string.Empty, "Pedidos", null, body);
                }
            }
        }

        public Pedido RemoverDaFila()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "testes",
                Password = "Testes2018!"
            };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("Pedidos", true, false, false, null);

                    var result = channel.BasicGet("Pedidos", true);

                    if (result != null)
                    {
                        var body = Encoding.UTF8.GetString(result.Body);

                        return JsonConvert.DeserializeObject<Pedido>(body);
                    }

                    return null;
                }
            }
        }
    }
}