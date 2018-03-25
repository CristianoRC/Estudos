using System;

namespace VarDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                var -  tempo de compilação
                dynamic - tempo de execução
             */

            dynamic d1 = new { Nome = "Cristiano" };

            Console.WriteLine(d1.Nome);
            /*
            * Console.WriteLine(d1.Email);
            *   
            * Solta um exeption no tempo de execução: 
            * does not contain a definition for 'Email'
           */
        }
    }
}
