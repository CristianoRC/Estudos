using System;
namespace ExtensionMethods
{
	internal static class Extension
	{
		internal static string ObterDataBrasileira(this DateTime data)
		{
			return data.ToString("dd/MM/yyyy HH:mm:ss");
		}

		internal static int ConverterParaInt(this string Entrada)
		{
			return Convert.ToInt32(Entrada);
		}
	}
}
