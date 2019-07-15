using System;

namespace Factory
{
    /*
     *
     * Modo de instanciar uma classe em tempo de execução,
     * sem saber a implementação.
     * Apenas com o conhecimento de sua interface.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var halloFactory = new HelloFactory();

            var linguage = halloFactory.Create(ELinguages.Spanish);

            linguage.SayHello();
        }
    }
}
