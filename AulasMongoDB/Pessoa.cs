using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AulasMongoDB
{
    public sealed class Pessoa
    {
        public ObjectId _id { get; set; }
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