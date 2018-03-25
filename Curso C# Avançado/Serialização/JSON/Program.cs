using System;
using System.IO;
using Newtonsoft.Json;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite seu Documento: ");
            pessoa.Documento = Console.ReadLine();

            Console.Write("Digite seu Email: ");
            pessoa.Email = Console.ReadLine();

            Console.WriteLine("\nAperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();


            using (var strean = new StreamWriter($"{Directory.GetCurrentDirectory()}/Resultado.JSON"))
            {
                strean.Write(JsonConvert.SerializeObject(pessoa));

                Console.WriteLine("Serializado com sucesso!");
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            }

            Console.Clear();

            using (var strean = new StreamReader($"{Directory.GetCurrentDirectory()}/Resultado.JSON"))
            {
                var result = JsonConvert.DeserializeObject<Pessoa>(strean.ReadToEnd());

                Console.WriteLine($"Deserialização: {result.Nome} / {result.Documento} / {result.Email}");
            }
        }
    }

    public class Pessoa
    {
        public Pessoa()
        {
            Nome = "Cristiano R. Cunha";
            Documento = "123.456.789-10";
            Email = "contato@cristianoprogramador.com";
        }

        public Pessoa(string nome, string documento, string email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
        }

        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
    }
}
