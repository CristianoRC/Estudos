namespace Contato.Models
{
    public class Mensagem
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Motivo { get; set; }
        public string Conteudo { get; set; }
        public bool Verificada { get; set; }

        public Mensagem()
        {
            Verificada = false;
        }
    }
}