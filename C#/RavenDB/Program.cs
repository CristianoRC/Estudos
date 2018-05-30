using System;
using System.Collections.Generic;
using System.Linq;

namespace AulasRavenDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            var repositorio = new RepositorioPessoa();

            //cadastrarViaTerminal(pessoa, repositorio);

            //listarViaTerminal(repositorio,repositorio.ListarTodas());
            //listarViaTerminal(repositorio, repositorio.Buscar("Cristiano"));
            //listarViaTerminal(repositorio, repositorio.Buscar(19));

            //atualizarViaTerminal(pessoa, repositorio);

            Console.Write("Insira o ID:");
            var id = Console.ReadLine();
            pessoa = repositorio.Deletar(id);
            Console.WriteLine($"\nUsuário \'{pessoa.Nome} {pessoa.Sobrenome}\' deletado com sucesso!");
        }

        static void cadastrarViaTerminal(Pessoa pessoa, RepositorioPessoa repositorio)
        {
            Console.Write("Digite o Nome:");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o Sobrenome:");
            pessoa.Sobrenome = Console.ReadLine();

            Console.Write("Digite a Idade:");
            pessoa.Idade = Convert.ToByte(Console.ReadLine());

            Console.Write("Ativar Usuário? (S/N):");
            var resposta = Console.ReadLine().ToLower().Trim();

            if (resposta.Equals("s"))
                pessoa.StatusAtivo = true;

            repositorio.Cadastrar(pessoa);

            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }

        static void atualizarViaTerminal(Pessoa pessoa, RepositorioPessoa repositorio)
        {
            Console.Write("Digite o ID:");
            var id = Console.ReadLine();

            Console.Write("Digite o Nome:");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o Sobrenome:");
            pessoa.Sobrenome = Console.ReadLine();

            Console.Write("Digite a Idade:");
            pessoa.Idade = Convert.ToByte(Console.ReadLine());

            Console.Write("Ativar Usuário? (S/N):");
            var resposta = Console.ReadLine().ToLower().Trim();

            if (resposta.Equals("s"))
                pessoa.StatusAtivo = true;

            repositorio.Atualizar(pessoa, id);

            Console.WriteLine("Pessoa Atualizada com sucesso!");
        }

        static void listarViaTerminal(RepositorioPessoa repositorio, IEnumerable<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {

                Console.WriteLine($"ID: {pessoa.Id}");
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Sobrenome: {pessoa.Sobrenome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");

                var statusUsuario = "Desativo";
                if (pessoa.StatusAtivo == true)
                    statusUsuario = "Ativo";
                Console.WriteLine($"Status Usuário: {statusUsuario}\n\n");
            }
        }
    }
}
