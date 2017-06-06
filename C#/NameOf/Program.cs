using System;

namespace NameOf
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Método NameOF retorna o nome de uma variavel.\n");

			var nome = "Cristiano Raffi Cunha";
			var idade = 18;

			Console.WriteLine($"{nameof(nome)}: {nome}");
			Console.WriteLine($"{nameof(idade)}: {idade}");

			Console.ReadKey();
		}
	}
}
