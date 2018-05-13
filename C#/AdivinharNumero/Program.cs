using System;

namespace AdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMenor = 0;
            int valorMaior = 100;
            int valorAtual;
            var valorEncontrado = false;

            Console.WriteLine("Olá, bem vindo ao adivinhador de numeros");
            Console.WriteLine("Pense em um numero de 0 a 100 que o software ira \"adivinhar\" com perguntas simples.");

            do
            {
                valorAtual = (valorMaior - valorMenor) / 2;

                Console.Write("\n\n O seu valor é <, > ou = a " + valorAtual + "? ");
                var resposta = Console.ReadLine().Trim();

                switch (resposta)
                {
                    case ">":
                        valorMenor = valorAtual + 1;
                        break;
                    case "<":
                        valorMaior = valorAtual - 1;
                        break;
                    case "=":
                        valorEncontrado = true;
                        break;
                    default:
                        Console.WriteLine("\"" + resposta + "\"" + " é um valor inválido");
                        break;
                }

            } while (!valorEncontrado);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nSeu valor foi encontrado -  " + valorAtual);

            Console.ReadKey();
        }
    }
}