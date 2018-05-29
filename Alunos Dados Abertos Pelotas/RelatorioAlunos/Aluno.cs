using System;
using MongoDB.Bson;

namespace RelatorioAlunos
{
    public sealed class Aluno
    {
        public ObjectId _id { get; set; }
        public int Matricula { get; set; }
        public string Serie { get; set; }
        public string Escola { get; set; }
        public string Bairro { get; set; }
        public string Etinia { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string NecessidadesEducacionaisEspeciais { get; set; }
    }
}