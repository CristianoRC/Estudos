using System;

namespace AdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMenor = 0;
            int valorMaior = 100;
            int valorPergunta = (valorMaior - valorMenor) / 2;
            var valorEncontrado = false;

            Console.WriteLine("Olá, bem vindo ao adivinhador de numeros");
            Console.WriteLine("Pense em um numero de 1 a 100 que o software ira \"adivinhar\" com perguntas simples.");

            do
            {
                Console.Write("\n\n O seu valor é <, > ou = a " + valorPergunta + "? ");
                var resposta = Console.ReadLine().Trim();

                switch (resposta)
                {
                    case ">":
                        valorMenor = ++valorPergunta;
                        valorPergunta = valorMenor + ((valorMaior - valorMenor) / 2);
                        break;
                    case "<":
                        valorMaior = --valorPergunta;
                        valorPergunta = valorMaior - ((valorMaior - valorMenor) / 2);
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
            Console.WriteLine("\n\nSeu valor foi encontrado -  " + valorPergunta);

            Console.ReadKey();
        }
    }
}