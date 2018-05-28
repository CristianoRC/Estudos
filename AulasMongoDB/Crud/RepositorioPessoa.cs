using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AulasMongoDB
{
    public class RepositorioPessoa
    {
        public RepositorioPessoa()
        {
            var cliente = new MongoClient("mongodb://192.168.0.110:27017");
            var dataBase = cliente.GetDatabase("Aulas");
            pessoas = dataBase.GetCollection<Pessoa>("Pessoa");
        }

        private IMongoCollection<Pessoa> pessoas { get; set; }

        public void Cadastrar(Pessoa pessoa)
        {
            pessoas.InsertOne(pessoa);
        }

        public List<Pessoa> ListarTodas()
        {
            return pessoas.Find(x => true).ToList();//x => true - Retorna tudo
        }

        public IEnumerable<Pessoa> Buscar(string nome)
        {
            return pessoas.Find(pessoa => pessoa.Nome.Equals(nome)).ToList();
        }

        public IEnumerable<Pessoa> Buscar(byte idade)
        {
            return pessoas.Find(pessoa => pessoa.Idade.Equals(idade)).ToList();
        }

        public void Atualizar(Pessoa pessoa)
        {
            pessoas.ReplaceOne((x => x._id.Equals(pessoa._id)), pessoa);
        }

        public void Deletar(Pessoa pessoa)
        {
            pessoas.DeleteOne(x => x._id.Equals(pessoa._id));
        }
    }
}