using System;
using System.Diagnostics;

namespace RunShellScrpit
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				ProcessStartInfo ps = new ProcessStartInfo();
				ps.FileName = @"Aula.sh";
				ps.UseShellExecute = false;
				ps.RedirectStandardOutput = true;

				Process process = Process.Start(ps);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
		}
	}
}
