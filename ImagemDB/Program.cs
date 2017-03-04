using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImagemDB
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var ImagemNaMemoria =
				ConversorDeImagem.CopiarArquivoParaMemoria("/home/cristiano/Imagens/csharp.png");

			var resultado = ConversorDeImagem.ConverterImagemString(ImagemNaMemoria);

			Console.WriteLine(resultado);

			ConversorDeImagem.ConverterStringImagem(resultado);

			Console.ReadKey();
		}
	}
}
