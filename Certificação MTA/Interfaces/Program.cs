using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPessoa pessoaFisica = new PessoaFisica("Cristiano Raffi Cunha", "629.619.960-07");

                Console.WriteLine(pessoaFisica.ToString());

                pessoaFisica.Cadastrar();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Cadastro indisponível no momento, tente novamente mais tarde.");
            }
        }
    }

    public interface IPessoa
    {
        Guid ID { get; set; }
        string Nome { get; set; }

        void Cadastrar();
    }

    public class PessoaFisica : IPessoa
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public PessoaFisica(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
            ID = Guid.NewGuid();
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"ID:{ID}\nNome: {Nome}\nCPF: {CPF}";
    }
}
