using System;

namespace TiposNullable
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int? a = null;

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("Testes com tipos Nullable.\n" +
							  "São tipos que normalmente não recebem null, " +
							  "e com o uso do \' ?\' ele passa a receber null");

			Console.WriteLine("\n----------------\n");
			try
			{
				Console.WriteLine($"O valor de um inteiro com null - {a}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ocorreu um erro = {ex.Message}");
			}

			Console.Write("\n----------------\n");

			Console.WriteLine("\nVerificando se a variavel tem um valor - x.HasValue\n");

			if (!a.HasValue)
			{
				Console.WriteLine("O valor da variavel é null.");
			}
			else
			{
				Console.WriteLine($"O valor da variavel é {a}");
			}

			Console.WriteLine("\nPassando um valor para a variável - 10\n");

			a = 10;

			if (!a.HasValue)
			{
				Console.WriteLine("O valor da variavel é null.");
			}
			else
			{
				Console.WriteLine($"O valor da variavel é {a}");
			}



			Console.ReadKey();
		}
	}
}
