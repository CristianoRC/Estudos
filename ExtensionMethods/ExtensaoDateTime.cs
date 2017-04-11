using System;
using System.Globalization;

namespace ExtensionMethodsDate
{
	internal static class Extension
	{
		internal static string ObterDiaDaSemana(this DateTime data)
		{
			int diaDaSemana = (int)data.DayOfWeek;

			return DateTimeFormatInfo.CurrentInfo.DayNames[diaDaSemana];
		}
	}
}
