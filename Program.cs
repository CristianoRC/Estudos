using System;

namespace MetodosAssincronos
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Estado
			DotCEP.Localidades.Estado.ObterNomeDoEstado("RS");

			DotCEP.Localidades.Estado.ObterCodigoDoEstado("RS");

			DotCEP.Localidades.Estado.ObterSiglaDoEstado("Rio Grande do Sul");


			//Municipio
			DotCEP.Localidades.Municipio.ObterCodigoDoMunicipio("Pelotas", DotCEP.UF.RS);

			DotCEP.Localidades.Municipio.ObterInformacoesDoMunicipio(4314407);

			DotCEP.Localidades.Municipio.ObterListaDeMunicipio(DotCEP.UF.RS);

			DotCEP.Localidades.Municipio.ObterListaDeMunicipio();

			DotCEP.Localidades.Municipio.ObterNomeDoMunicipio(4314407);
		}
	}
}
