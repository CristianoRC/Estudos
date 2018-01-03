using System;

namespace Estruturas_de_decisão
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Operadores ?:
                Condição ? PrimeiraExpressão : SeguindaExpressão;
                                TRUE                FALSE 
            */
            var idade = 17;

            var Maioridade = idade >= 18 ? true : false;

            Console.WriteLine(Maioridade);
        }
    }
}
