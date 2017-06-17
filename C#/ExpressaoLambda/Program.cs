using System;
using System.Linq;
using System.Net.Sockets;

namespace ExpressaoLambida
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 159, -30, 10, 0, 0 };
            int oddNumbers = numbers.Count(n => n != 1);

            var numerosPares = from it in numbers
                               where it % 2 == 0
                               select it;

            var numerosImpares = numbers.Where(it => it % 2 != 0);

            var numerosOrdenados = numbers.OrderBy(it => it);

            var numerosOrdenadosReverso = numerosOrdenados.Reverse();

            var numerosOrdenadosDestintos = numerosOrdenados.Distinct();

            #region Impressão na tela

            Console.WriteLine("\nLista de numero pares:\n");

            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nLista de numero impares:\n");

            foreach (var item in numerosImpares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nLista de numero ordenada:\n");

            foreach (var item in numerosOrdenados)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nLista de numero ordenada reverso:\n");

            foreach (var item in numerosOrdenadosReverso)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\nLista de numero ordenada distintos:\n");

            foreach (var item in numerosOrdenadosDestintos)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
