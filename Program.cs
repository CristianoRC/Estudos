using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MetodosAssincronos
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ObterHTMLdoSite();
		}
		
		async static Task ObterHTMLdoSite()
		{
			HttpClient cliente = new HttpClient();

			var resposta = await cliente.GetStringAsync("http://msn.com.br");
		}
	}
}
