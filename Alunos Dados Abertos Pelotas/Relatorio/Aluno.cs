using System;

namespace Relatorio
{
    public sealed class Aluno
    {
        public string Id { get; set; }
        public int? Matricula { get; set; }
        public string Serie { get; set; }
        public string Escola { get; set; }
        public string Bairro { get; set; }
        public string Etinia { get; set; }
        public ESexo? Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string NecessidadesEducacionaisEspeciais { get; set; }
    }
}