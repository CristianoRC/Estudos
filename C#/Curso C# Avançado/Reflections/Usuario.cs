namespace Reflections
{
    public class Usuario : System.ICloneable
    {
        public Usuario()
        {

        }

        public Usuario(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public object Clone()
        {
            return new Usuario(this.Nome, this.Email, this.Senha);
        }
    }
}