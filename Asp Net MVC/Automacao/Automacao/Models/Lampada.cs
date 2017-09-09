using System;
using System.IO.Ports;
using System.Threading;

namespace Automacao.Models
{
    public class Lampada
    {
        private SerialPort comunicacao = new SerialPort("/dev/ttyACM0", 9600);

        internal void Desligar()
        {
            byte[] valor = {1};
            comunicacao.Open();
            comunicacao.Write(valor, 0, 1);
            comunicacao.Close();
        }

        internal void Ligar()
        {
            byte[] valor = {1};
            comunicacao.Open();
            comunicacao.Write(valor, 0, 1);
            comunicacao.Close();
        }
    }
}