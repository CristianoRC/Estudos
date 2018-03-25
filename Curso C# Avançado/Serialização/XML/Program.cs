using System;
using System.IO;
using System.Xml.Serialization;

namespace XML
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

            var serializer = new XmlSerializer(pessoa.GetType());

            using (var strean = new StreamWriter($"{Directory.GetCurrentDirectory()}/Resultado.xml"))
            {
                serializer.Serialize(strean, pessoa);

                Console.WriteLine("Serializado com sucesso!");
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            }

            Console.Clear();

            using (var strean = new StreamReader($"{Directory.GetCurrentDirectory()}/Resultado.xml"))
            {
                var result = (Pessoa)serializer.Deserialize(strean);

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
