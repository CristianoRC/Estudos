using System;

namespace FuncoesInternas
{
	class MainClass
	{
		public static void Main(string[] args)
		{

		}

		private bool CompararSenhas(string primeiraSenha, string confirmacaoSenha)
		{
			if (!String.IsNullOrEmpty(primeiraSenha) && !String.IsNullOrEmpty(confirmacaoSenha))
			{

			}

			bool comparar()
			{
				if (primeiraSenha == confirmacaoSenha)
					return true;
				else
					return false;
			}

			return comparar();
		}
	}
}
