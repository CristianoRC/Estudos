using System;

namespace exemplos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
    public class MeuAtributo : Attribute
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome, string descricao)
        {
            Descricao = descricao;
            Nome = nome;
        }
    }
}