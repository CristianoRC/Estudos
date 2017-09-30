using System;
using System.Security.Cryptography;
using System.Text;

namespace SenhaConsole
{
    public static class LeituraDeSenha
    {
        public static string LerSenha()
        {
            StringBuilder pw = new StringBuilder();
            bool caracterApagado = false;

            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (deletarTexto(cki))
                {
                    if (pw.Length != 0)
                    {
                        Console.Write("\b \b");
                        pw.Length--;

                        caracterApagado = true;
                    }
                }
                else
                {
                    caracterApagado = false;
                }

                if (!caracterApagado && verificarCaracterValido(cki))
                {
                    Console.Write('•');
                    pw.Append(cki.KeyChar);
                }
            }

            return pw.ToString();
        }

        public static string LerSenhaHashMd5()
        {
            var saida = LerSenha();

            return gerarHashMd5(saida);
        }

        private static bool verificarCaracterValido(ConsoleKeyInfo tecla)
        {
            if (char.IsLetterOrDigit(tecla.KeyChar) || char.IsPunctuation(tecla.KeyChar) ||
                char.IsSymbol(tecla.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private static bool deletarTexto(ConsoleKeyInfo tecla)
        {
            if (tecla.Key == ConsoleKey.Backspace || tecla.Key == ConsoleKey.Delete)
                return true;
            else
                return false;
        }

        private static string gerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }
}