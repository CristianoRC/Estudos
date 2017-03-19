using System;

namespace ExtensionMethods
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(DateTime.Now.ObterDataBrasileira());

			Console.WriteLine("1998".ConverterParaInt());
		}
	}
}
