using System.Collections.Generic;
using System.Linq;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;

namespace Relatorio
{
    public class RepositorioEscola
    {
        public RepositorioEscola()
        {
            bancoDeDados = new DocumentStore()
            {
                Urls = new[] { "http://127.0.0.1:8080/" },
                Database = "estudos"
            }.Initialize();
        }

        IDocumentStore bancoDeDados;

        public Escola Buscar(string nome)
        {
            using (var sessao = bancoDeDados.OpenSession(new SessionOptions { }))
            {
                return sessao.Query<Escola>()
                .Where(Escola => Escola.Nome == nome)
                .FirstOrDefault();
            }
        }

        public IEnumerable<Escola> Listar()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Escola>().ToList();
            }
        }

        public long ObterNumeroDeEscolas()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Escola>().Count();
            }
        }

        public long ObterNumeroDeAlunos(string escola)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                escola = escola.ToUpper();

                return sessao.Query<Aluno>()
                .Where(aluno => aluno.Escola == escola)
                .Count();
            }
        }
    }
}