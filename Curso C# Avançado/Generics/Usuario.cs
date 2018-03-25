namespace Generics
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string nome, string senha, string email)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
        }

        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}