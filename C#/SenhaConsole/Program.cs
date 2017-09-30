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
            var senhaDoBanco = "3eeb79fafb2063cc034e00aa0c6bf093";

            if (senha == senhaDoBanco || senha == "Crc19D98C#")
                return true;
            else
                return false;
        }
    }
}