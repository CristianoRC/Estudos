using System;

namespace Join
{
    public class Autor
    {
        public Autor(string nome)
        {
            Nome = nome;
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
        public string Nome { get; set; }
    }
}