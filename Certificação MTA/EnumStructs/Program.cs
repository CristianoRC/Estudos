using System;

namespace EnumStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dias.Segunda);
            Console.WriteLine((byte)Dias.Segunda);

            Console.WriteLine("\n--------------------\n");

            var tempo = new Tempo(22, 50, 15);
            Console.WriteLine(tempo.ToString());
        }
    }

    public struct Tempo
    {
        public Byte Hora { get; private set; }
        public Byte Minuto { get; private set; }
        public Byte Segundo { get; private set; }

        public Tempo(Byte hora, Byte minuto, Byte segundo)
        {
            //Validação aqui
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
        }

        public override string ToString() => $"{Hora}:{Minuto}:{Segundo}";

    }

    public enum Dias : byte
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7
    }
}
