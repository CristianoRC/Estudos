using System;

namespace BasePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo(10m);
            Circulo copiaCirculo = c;
            Object CopiaObject = c;
            /*
                Todas as classes herdam de Object, 
                isso faz com que ela possa ter a referencia de circulo
                Tipos Object também podem receber objetos de valor.
            */

            Console.WriteLine($"Radio: {c.Raio} | Diametro: {c.Diametro}");
            copiaCirculo.AlterarRadio(50);
            /*
                Como os dois valores da stack referencia o mesmo objeto na Heap
                A alteração de um reflete no outro
             */

            Console.WriteLine($"Radio: {c.Raio} | Diametro: {c.Diametro}");

            /*
                U N B O X I N G
                Casting não seguro:
                Circulo CirculoCopiaDoObjeto = (Circulo)CopiaObject;

                Casting Seguro a baixo.

                AS --> Verifica se o objeto é do tipo correto, se for ele faz o unboxing.
                IS --> Verifica o Objeto e retorna um valor booleano.
             */

            Circulo CirculoCopiaDoObjeto = CopiaObject as Circulo;

            Console.WriteLine($"Radio: {CirculoCopiaDoObjeto.Raio} | Diametro: {CirculoCopiaDoObjeto.Diametro}");

            CirculoCopiaDoObjeto.AlterarRadio(45);
            Console.WriteLine($"Valor do Unboxing - Radio: {CirculoCopiaDoObjeto.Raio} | Diametro: {CirculoCopiaDoObjeto.Diametro}");
            Console.WriteLine($"Valor da instância -Radio: {c.Raio} | Diametro: {c.Diametro}");
        }
    }

    public class Circulo
    {
        public Circulo(decimal raio)
        {
            Raio = raio;
        }

        public decimal Raio { get; private set; }
        public decimal Diametro => Raio * 2;

        public void AlterarRadio(decimal raio)
        {
            Raio = raio;
        }
    }
}
