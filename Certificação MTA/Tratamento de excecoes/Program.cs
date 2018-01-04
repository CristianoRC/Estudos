using System;

namespace Tratamento_de_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var entrada = Convert.ToInt32(Console.ReadLine());
                var resultado = 15 / entrada;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Erro de divisão por zero: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
                //Catch "generico".
            }
            finally
            {
                Console.WriteLine("Final!");
            }
        }
    }
}
