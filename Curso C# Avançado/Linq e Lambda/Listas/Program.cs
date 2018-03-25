using System;
using System.Linq;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAMBDA - (entrada) => (expressão)

            short[] lista = { 5, 489, 6, 95, 32, 54, 10, 22, 0, -10, -1, 2 };

            var saida = lista.Where(x => x < 10).OrderBy(x => x).Select(x => x);

            foreach (var item in saida)
            {
                Console.WriteLine(item);
            }
        }
    }
}
