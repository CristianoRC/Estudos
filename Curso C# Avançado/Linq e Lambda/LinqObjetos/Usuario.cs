namespace LinqObjetos
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;

        }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}