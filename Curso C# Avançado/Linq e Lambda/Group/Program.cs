using System;
using System.Linq;

namespace Group
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] numeros = { 9, 9, 1, 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 6, 6, 7, 8, 8, 8, 9, 9 };

            var distinct = numeros.Distinct().OrderBy(x => x);
            var group = numeros.OrderBy(x => x).GroupBy(x => x).Select(x => x);

            Console.WriteLine("Distinct:");
            foreach (var item in distinct)
            {
                Console.Write($"{item}; ");
            }
            Console.WriteLine();

            Console.WriteLine("Group by:");
            foreach (var item in group)
            {
                Console.Write($"{item.Key}; ");
            }

        }
    }
}
