using System;

namespace Execoes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Olá Mundo");
                throw new ExecoesExemplo("Exemplo de erro C#");
            }
            catch (ExecoesExemplo ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
