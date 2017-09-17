using System;

namespace Delegates
{
    public class Delegates
    {
        public void ExecutarExemplo()
        {
            Calcular delegateSoma = new Calcular(somar);

            Console.WriteLine($"5 + 6 = {delegateSoma(5, 6)}");
        }

        delegate int Calcular(int x, int y);

        int somar(int x, int y)
        {
            return x + y;
        }

        int subtrair(int x, int y)
        {
            return x - y;
        }
    }
}