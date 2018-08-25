using System;
using System.Threading;

namespace MultiTrhead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Data inicial: {DateTime.Now}");
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(threadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }
        static void threadRepeticao()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"{i}; ");
            }
            Console.WriteLine($"Data final: {DateTime.Now}");
        }
    }
}
