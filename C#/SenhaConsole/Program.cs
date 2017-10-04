using System;

namespace SenhaConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Logar();
            }
            while (Console.ReadKey().Key == ConsoleKey.Escape);
        }

        private static void Logar()
        {
            Console.Write("Digite sua senha: ");
            var texto = LeituraDeSenha.LerSenhaHashMd5();

            Console.WriteLine("\n");

            Console.WriteLine($"Senha informada: {texto} \n\n");

            if (VerificarSenha(texto))
            {
                Console.WriteLine("Usuário autenticado com sucesso.");
            }
            else
            {
                Console.WriteLine("Senha inválida.");
            }
        }
        public static bool VerificarSenha(string senha)
        {
            var senhaDoBanco = "25f9e794323b453885f5181f1b624d0b";

            if (senha == senhaDoBanco)
                return true;
            else
                return false;
        }
    }
}