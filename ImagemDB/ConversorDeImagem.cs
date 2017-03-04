using System;
using System.IO;
using System.Drawing;
using System.Text;

namespace ImagemDB
{
	public static class ConversorDeImagem
	{
		public static String ConverterImagemString(System.Drawing.Image p_imagem)
		{
			MemoryStream ms = new MemoryStream();

			p_imagem.Save(ms, p_imagem.RawFormat);

			return Encoding.ASCII.GetString(ms.ToArray());
		}

		public static Image CopiarArquivoParaMemoria(string p_CaminhoDoArquico)
		{
			return Image.FromFile(p_CaminhoDoArquico);
		}

		public static void ConverterStringImagem(String p_imagem)
		{
			byte[] conversaoDaString = Encoding.ASCII.GetBytes(p_imagem);

			MemoryStream ms = new MemoryStream(conversaoDaString);

			var saida = Image.FromStream(ms);

			saida.Save("/home/cristiano/Documentos/Teste.png");

		}
	}
}
