namespace Autenticacao.Models
{
    public class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Pessoa(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = Ferramentas.ComputeSha256Hash(senha);
        }
        public Pessoa(string email, string senha)
        {
            this.Email = email;
            this.Senha = Ferramentas.ComputeSha256Hash(senha);
        }

        public bool Logar(PessoaRepositorio repositorio)
        {
            return repositorio.VarificarUsuario(this.Email, this.Senha);
        }
    }
}