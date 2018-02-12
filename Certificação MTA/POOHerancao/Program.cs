using System;

namespace POOHerancao
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoaFisica = new PessoaFisiaca(19, "Cristiano Cunha", "624.996.550-54");
            var pessoaJuridica = new PessoaJuridica("Cristiano Cunha solusções em TI", "86.373.000/0001-52");

            Console.WriteLine(pessoaFisica.ToString());
            Console.WriteLine($"\n{pessoaJuridica.ToString()}");
        }
    }

    public abstract class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public void Salvar()
        {

        }
    }

    public class PessoaFisiaca : Pessoa
    {
        public string CPF { get; private set; }
        public byte Idade { get; private set; }

        public PessoaFisiaca(byte idade, string nome, string cpf) : base(nome)
        {
            CPF = cpf;
            Idade = idade;

            Salvar();
        }

        public override string ToString() => $"{base.Nome}, {Idade} anos, CPF: {CPF}";
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public PessoaJuridica(string nome, string cnpj) : base(nome)
        {
            CNPJ = cnpj;
        }

        public override string ToString() => $"{base.Nome}, CNPJ: {CNPJ}";
    }

}
