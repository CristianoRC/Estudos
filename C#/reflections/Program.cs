using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirInformacoes();
            Console.WriteLine("***********************");
            ExibirPropriedades();
            Console.WriteLine("***********************");
            ExibirConstrutores();
        }

        static void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {typeof(Pessoa).Name}");
            Console.WriteLine($"Namespace: {typeof(Pessoa).Namespace}");
            Console.WriteLine($"Caminho: {typeof(Pessoa).FullName}");
            Console.WriteLine($"E public: {typeof(Pessoa).IsPublic}");
        }

        static void ExibirPropriedades()
        {
            var camposPessoa = typeof(Pessoa).GetProperties();

            camposPessoa
            .ToList()
            .ForEach(p =>
            {
                Console.WriteLine($"{p.Name} - {p.PropertyType}");
                Console.WriteLine($"Leitura Permitida: {p.CanRead}");
                Console.WriteLine($"Escrita Permitida: {p.CanWrite}");
                Console.WriteLine("------------");
            });
        }

        static void ExibirConstrutores()
        {
            typeof(Pessoa).GetConstructors().ToList()
            .ForEach(c =>
            {
                Console.WriteLine($"Nome: {c.Name}");
                Console.WriteLine($"Publico: {c.IsPublic}");
                ExibirParametros(c.GetParameters());
            });
        }

        static void ExibirParametros(IEnumerable<ParameterInfo> parameterInfos)
        {
            Console.WriteLine("Parametros: ");
            foreach(var parameter in parameterInfos)
            {
                Console.WriteLine($"\tNome: {parameter.Name}");
                Console.WriteLine($"\tTipo: {parameter.ParameterType}");
                Console.WriteLine($"\tOpcional: {parameter.IsOptional}");
                Console.WriteLine($"\tPosicao: {parameter.Position}");
                Console.WriteLine("\t ----");
            }
        }
    }
}
