using System;
using System.Collections.Generic;
using ExtensionMethodsDate;
using DotCEP;


namespace ExtensionMethods
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			String DataAtual = DateTime.Now.ObterDataFormatada();
			
			Console.WriteLine(DateTime.Now.ValidarIntervaloDeTempo(DataAtual));
		}
	}
}
