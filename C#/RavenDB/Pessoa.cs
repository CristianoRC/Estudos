using System;
using System.Collections.Generic;


namespace AulasRavenDB
{
    public sealed class Pessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
        public bool StatusAtivo { get; set; }

        public Pessoa()
        {
            StatusAtivo = false;
        }
    }
}