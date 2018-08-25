using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AulasTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Task.Factory.StartNew(ManipularEbook);
                //ManipularEbook();
            }
            catch (System.Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Digite sobre você enquanto é feito o download do seu Ebook:");
            Console.ReadLine();
        }


        static async void ManipularEbook()
        {
            Console.WriteLine("Efetuando Download aguarde...");

            var arquivo = $"{Directory.GetCurrentDirectory()}/Ebook.pdf";
            WebClient client = new WebClient();
            var uriEbook = new Uri("https://www.caelum.com.br/download/caelum-csharp-dotnet-fn13.pdf");

            await client.DownloadFileTaskAsync(uriEbook, arquivo);

            Console.WriteLine($"Dowload finalizado: {DateTime.Now}");
        }
    }
}
