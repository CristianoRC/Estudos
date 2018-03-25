using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario("Cristiano Cunha", "123", "contato@cristianoprogramador.com");
            var casa = new Casa("Pelotas", "AV Ferreira Viana");
            var Carro = new Carro("Toyota", "Hilux SW4");

            Serializador.Serializar(usuario);
            Serializador.Serializar(casa);
            Serializador.Serializar(Carro);

            var usuario2 = Serializador.Desserializar<Usuario>();
            var casa2 = Serializador.Desserializar<Casa>();
            var carro2 = Serializador.Desserializar<Carro>();

            Console.WriteLine($"Usuario {usuario2.Nome};\nCidade {casa2.Cidade};\nCarro {carro2.Modelo};");
        }
    }
}
