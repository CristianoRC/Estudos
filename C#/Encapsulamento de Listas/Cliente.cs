using System;

namespace Encapsulamento_de_Listas
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.ID = Guid.NewGuid();
            this.Nome = nome;

            if (string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Cliente inválido");
            }
        }

        public Cliente(Guid iD, string nome)
        {
            this.ID = iD;
            this.Nome = nome;

            if (string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Cliente inválido");
            }
        }
        public Guid ID { get; private set; }

        public string Nome { get; private set; }


    }
}