using System;

namespace ListasEncadeadas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new Lista();

            lista.Adicionar("Cristiano");
            Console.WriteLine($"Primeiro valor: {lista.PrimeiroNo.Valor}");
            Console.WriteLine($"Ultimo valor: {lista.UltimoNo.Valor}\n");

            lista.Adicionar("Cristiano 2");
            Console.WriteLine($"Primeiro valor: {lista.PrimeiroNo.Valor}");
            Console.WriteLine($"Ultimo valor: {lista.UltimoNo.Valor}\n");

            lista.Adicionar("Cristiano 3");
            Console.WriteLine($"Primeiro valor: {lista.PrimeiroNo.Valor}");
            Console.WriteLine($"Ultimo valor: {lista.UltimoNo.Valor}\n");

            Console.WriteLine("\n\nListagem dos valores");

            foreach (var item in lista.ObterValores())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nValor Deletado: Cristiano 3");
            lista.Deletar("Cristiano");
            Console.WriteLine($"Primeiro valor: {lista.PrimeiroNo.Valor}");
            Console.WriteLine($"Ultimo valor: {lista.UltimoNo.Valor}\n");

            Console.WriteLine("\n\nListagem dos valores");

            foreach (var item in lista.ObterValores())
            {
                Console.WriteLine(item);
            }
        }
    }
}
