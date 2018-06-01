using System.Collections.Generic;
using System.Linq;
using Raven.Client.Documents;

namespace Contato.Models
{
    public class MensagemRepositorio
    {
        public MensagemRepositorio()
        {
            bancoDeDados = new DocumentStore()
            {
                Urls = new[] { "http://127.0.0.1:8080" },
                Database = "estudos"
            };
            bancoDeDados.Initialize();
        }

        DocumentStore bancoDeDados;

        public void Cadastrar(Mensagem Mensagem)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                Mensagem.Id = sessao.Advanced.GetDocumentId(Mensagem);
                sessao.Store(Mensagem);
                sessao.SaveChanges();
            }
        }

        public Mensagem Buscar(string Id)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Load<Mensagem>(Id);
            }
        }
        public IEnumerable<Mensagem> Listar()
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                return sessao.Query<Mensagem>().ToList().OrderBy(x=> x.Verificada);
            }
        }

        public void Deletar(string id)
        {

            using (var sessao = bancoDeDados.OpenSession())
            {
                var mensagem = sessao.Load<Mensagem>(id);

                if (mensagem.Id != null)
                {
                    sessao.Delete(mensagem);
                    sessao.SaveChanges();
                }
            }
        }

        public void AtualizarStatusVerificada(string id, bool status)
        {
            using (var sessao = bancoDeDados.OpenSession())
            {
                var mensagem = sessao.Load<Mensagem>(id);

                if (mensagem.Id != null)
                {
                    if (mensagem.Verificada != status)
                    {
                        mensagem.Verificada = status;
                        sessao.SaveChanges();
                    }
                }
            }
        }
    }
}