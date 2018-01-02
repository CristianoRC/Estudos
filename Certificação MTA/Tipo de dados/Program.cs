using System;

namespace Tipo_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pessoa = new Aluno(19, "Cristiano", 'M');
                Console.WriteLine($"Nome: {pessoa.Nome} | Idade: {pessoa.Idade} | Sexo: {pessoa.Sexo} | Tipo: {pessoa.Tipo}");

                Console.Write("\nDigite a nova idade:");
                var novaIdade = Convert.ToByte(Console.ReadLine());

                pessoa.AlterarIdade(novaIdade);
                Console.WriteLine($"\nNome: {pessoa.Nome} | Idade: {pessoa.Idade} | Sexo: {pessoa.Sexo} | Tipo: {pessoa.Tipo}");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    internal class Aluno
    {
        private const char tipoPessoa = 'F';

        private readonly char? sexoPessoa;

        //private readonly char sexoPessoa = 'M'; Os dois modos podem ser utilizados

        internal Aluno(byte idade, string nome, char? sexo)
        {
            this.Idade = idade;
            this.Nome = nome;
            this.sexoPessoa = sexo;

            //tipoPessoa = 'd'; Não é possível
        }
        public byte Idade { get; private set; }
        public string Nome { get; private set; }
        public char Tipo => tipoPessoa;
        public char? Sexo => sexoPessoa;


        public void AlterarIdade(byte idade)
        {
            Idade = idade;
        }

        public void AlterarSexo(char sexo)
        {
            //this.sexoPessoa = sexo; Não é possível atualizar o valor.
        }
    }
}
