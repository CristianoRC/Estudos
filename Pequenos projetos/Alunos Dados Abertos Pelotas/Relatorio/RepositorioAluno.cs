using Raven.Client.Documents;
using System.Collections.Generic;
using System.Linq;

namespace Relatorio
{
    public class RepositorioAluno
    {

        public RepositorioAluno()
        {
            bancoDeDados = new DocumentStore()
            {
                Urls = new[] { "http://127.0.0.1:8080" },
                Database = "estudos"
            };
            bancoDeDados.Initialize();
        }

        DocumentStore bancoDeDados;

        public Aluno Buscar(int matricula)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Aluno>()
                .Where(aluno => aluno.Matricula == matricula)
                .FirstOrDefault();
            }
        }

        public long ObterNumeroDeAlunosSexo(ESexo sexo)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                if (sexo.Equals(ESexo.Outro))
                {
                    return sessao.Query<Aluno>()
                    .Where(aluno => aluno.Sexo != ESexo.Masculino
                            && aluno.Sexo != ESexo.Feminino)
                    .ToList()
                    .Count();
                }

                return sessao.Query<Aluno>()
                .Where(aluno => aluno.Sexo == sexo)
                .ToList()
                .Count();
            }
        }


        public long ObterNumeroDeAlunosBairro(string bairro)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Aluno>()
                .Where(aluno => aluno.Bairro == bairro)
                .ToList()
                .Count();
            }
        }

        public long ObterNumeroDeAlunosComNecessidades()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Aluno>()
                .Where(aluno => aluno.NecessidadesEducacionaisEspeciais != "SEM NECESSIDADES ESPECIAIS")
                .ToList()
                .Count();
            }

        }

        public long ObterNumeroDeAlunos()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Aluno>().ToList().Count();
            }
        }

        public long ObterNumeroDeAlunosFormandos()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Aluno>()
                .Search(Aluno => Aluno.Serie, "8ª")
                .Search(Aluno => Aluno.Serie, "9º")
                .Count();
            }
        }
    }
}