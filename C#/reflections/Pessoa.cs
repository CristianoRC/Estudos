namespace reflections
{
    public class Pessoa
    {
        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome, uint idade = 22)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;

        }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
        
        public uint Idade { get; set; }
    }
}