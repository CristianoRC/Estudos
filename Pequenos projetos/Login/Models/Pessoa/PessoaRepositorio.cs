using System.Linq;
using Raven.Client.Documents;

namespace Autenticacao.Models
{
    public class PessoaRepositorio
    {
        public PessoaRepositorio()
        {
            bancoDeDados = new DocumentStore()
            {
                Urls = new[] { "http://127.0.0.1:8080" },
                Database = "estudos"
            }.Initialize();
        }

        IDocumentStore bancoDeDados;

        public void Cadastrar(Pessoa pessoa)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                sessao.Store(pessoa);
                sessao.SaveChanges();
            }
        }

        public bool VarificarUsuario(string email, string senha)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                var quantidade = sessao.Query<Pessoa>()
                .Where(x => x.Email.Equals(email) && x.Senha.Equals(senha)).Count();

                if (quantidade > 0)
                    return true;
            }
            return false;
        }
    }
}