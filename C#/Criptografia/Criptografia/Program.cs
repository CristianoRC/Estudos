using System;
using System.Security.Cryptography;
using System.Text;

namespace Criptografia
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite sua senha: ");
			var texto = Console.ReadLine();
			Console.WriteLine("\n");

			if (VerificarSenha(texto))
			{
				Console.WriteLine("Usuário autenticado com sucesso.");
			}
			else
			{
				Console.WriteLine("Senha inválida.");
			}

			Console.ReadKey();
		}

		private static string GerarHashMd5(string input)
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

		public static bool VerificarSenha(string Senha)
		{
			var senhaDoBanco = "Hash do banco";
			var senhaInformada = GerarHashMd5(Senha);

			if (senhaInformada == senhaDoBanco)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}