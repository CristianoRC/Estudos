using System;
using System.IO.Ports;
using System.Diagnostics;

namespace ComunicacaoArduino
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var portas = SerialPort.GetPortNames();

            foreach (var item in portas)
            {
                Console.WriteLine($"Porta - {item}");
            }

            Console.WriteLine("\n----------\n\n");


            using (SerialPort comunicacao = new SerialPort("/dev/ttyACM0", 9600))
            {
                comunicacao.Open();
                Console.WriteLine(comunicacao.ReadLine() + "\n\n-----\n\n");

                var manusearLED = true;

                while (manusearLED)
                {
                    Console.Clear();

                    Console.Write("\nDigite 'L' para ligar e 'D' para desligar:");

                    var resultado = Console.ReadLine();

                    comunicacao.Write(resultado.ToUpper());

                    Console.WriteLine(comunicacao.ReadLine());

                    Console.WriteLine("\n\nDesenha sair (S/N): ");

                    var resultadoSair = Console.ReadLine();

                    if (resultadoSair == "S")
                        manusearLED = false;
                }

                comunicacao.Close();
            }

            Console.ReadKey();
        }
    }
}
