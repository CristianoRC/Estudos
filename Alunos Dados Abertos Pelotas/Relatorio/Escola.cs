using MongoDB.Bson;

namespace Relatorio
{
    public class Escola
    {
        public ObjectId _id { get; set; }
        public string NomeEscola { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
    }
}