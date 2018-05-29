using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace Relatorio
{
    public class RepositorioEscola
    {
        public RepositorioEscola()
        {
            var cliente = new MongoClient(@"mongodb://AlunosPelotas:Pelotas20*18@ds016298.mlab.com:16298/estudos");
            var dataBase = cliente.GetDatabase("estudos");
            escolas = dataBase.GetCollection<Escola>("EscolasPelotas");
            alunos = dataBase.GetCollection<Escola>("AlunosPelotas");
        }

        IMongoCollection<Escola> escolas;
        IMongoCollection<Escola> alunos;

        public Escola Buscar(string nome)
        {
            return escolas.Find(escolas => escolas.NomeEscola.Equals(nome)).FirstOrDefault();
        }

        public IEnumerable<Escola> Listar()
        {
            return escolas.Find(x => true).ToList().OrderBy(x => x.Bairro);
        }

        public long ObterNumeroDeEscolas()
        {
            return escolas.Find(x => true).Count();
        }
    }
}