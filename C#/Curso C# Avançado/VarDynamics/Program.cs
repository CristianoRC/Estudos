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

            dynamic pessoa = new { Nome = "Cristiano",Sobrenome = "Raffi Cunha", Idade = 19 };

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Sobrenome);
            Console.WriteLine(pessoa.Idade);
            /*
            * Console.WriteLine(d1.Email);
            *   
            * Solta um exeption no tempo de execução: 
            * does not contain a definition for 'Email'
           */
        }
    }
}
