using System.Collections.Generic;
using System.Linq;
using Raven.Client.Documents;

namespace AulasRavenDB
{
    public class RepositorioPessoa
    {
        public RepositorioPessoa()
        {
            bancoDeDados = new DocumentStore()
            {
                Urls = new[] { "http://127.0.0.1:8080/" },
                Database = "CRUD"
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

        public IEnumerable<Pessoa> ListarTodas()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Pessoa>().ToList();
            }
        }

        public IEnumerable<Pessoa> Buscar(string nome)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return (from pessoas in sessao.Query<Pessoa>()
                        where pessoas.Nome == nome
                        select pessoas).ToList();
            }
        }

        public IEnumerable<Pessoa> Buscar(byte idade)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return (from pessoa in sessao.Query<Pessoa>()
                        where pessoa.Idade == idade
                        select pessoa).ToList();
            }
        }

        public void Atualizar(Pessoa pessoa, string id)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                var pessoaTemp = sessao.Load<Pessoa>(id);

                pessoaTemp.Idade = pessoa.Idade;
                pessoaTemp.Nome = pessoa.Nome;
                pessoaTemp.Sobrenome = pessoa.Sobrenome;
                pessoaTemp.StatusAtivo = pessoa.StatusAtivo;

                sessao.SaveChanges();
            }
        }

        public Pessoa Deletar(string id)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                var pessoaTemp = sessao.Load<Pessoa>(id);
                sessao.Delete(pessoaTemp);
                sessao.SaveChanges();
                return pessoaTemp;
            }
        }
    }
}