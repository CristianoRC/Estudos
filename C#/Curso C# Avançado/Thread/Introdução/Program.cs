using System;
using System.Threading;

namespace AulasThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(threadRepeticao);
            t1.Start();


            for (int i = 1000; i >= 0; i--)
            {
                Console.WriteLine($"Main {i}; ");
            }
        }

        static void threadRepeticao()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"{i}; ");
            }
        }
    }
}
