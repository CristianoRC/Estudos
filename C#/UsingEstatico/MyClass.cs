using System;
using static System.Convert;

namespace UsingEstatico
{
	public class MyClass
	{
		//Sem a utilização de Using Estático
		public static int ConverterParaInteiro(string valor)
		{
			try
			{
				return System.Convert.ToInt32(valor);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public static double ConverterParaReais(string valor)
		{
			try
			{
				return ToDouble(valor);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
	}
}
