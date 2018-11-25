using System;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum.TryParse((typeof(Cores)), "0", out var saidaConversao);

            Console.WriteLine(saidaConversao == null ? "Valor NULL" : saidaConversao);
        }
    }

    public enum Cores
    {
        Azul,
        Preto,
        Branco
    }
}
