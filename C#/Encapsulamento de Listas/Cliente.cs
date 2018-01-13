using System;

namespace Encapsulamento_de_Listas
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Cliente inválido");
            }

            this.ID = Guid.NewGuid();
            this.Nome = nome;
        }

        public Cliente(Guid iD, string nome)
        {

            if (string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Cliente inválido");
            }

            this.ID = iD;
            this.Nome = nome;
        }
        public Guid ID { get; private set; }

        public string Nome { get; private set; }
    }
}