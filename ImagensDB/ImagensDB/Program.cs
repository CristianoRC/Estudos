using System;
using System.Windows.Forms;

namespace ImagensDB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            setarCorConsoleAzul();
            Console.WriteLine("\t\t\t\tImagens no Banco de Dados C#\n\n");

            Console.ReadKey();

            preencherPessoa();

            Console.ReadKey();
        }

        private static Pessoa preencherPessoa()
        {
            Pessoa pessoaBase = new Pessoa();

            setarCorConsoleAmarelo();
            Console.Write("Nome:");
            setarCorConsoleBranco();
            pessoaBase.Nome = Console.ReadLine();

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleAmarelo();
            Console.Write("CPF:");
            setarCorConsoleBranco();
            pessoaBase.CPF = Convert.ToUInt64(Console.ReadLine());

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleAmarelo();
            Console.Write("CEP:");
            setarCorConsoleBranco();
            pessoaBase.CEP = Convert.ToUInt64(Console.ReadLine());
            mostrarInformacoesDoCEP(pessoaBase.CEP.ToString());

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleAmarelo();
            Console.Write("Imagen:");
            pessoaBase.CaminhoImagen = Console.ReadLine();

            setarCorConsoleBranco();

            return pessoaBase;
        }

        private static void mostrarInformacoesDoCEP(string CEP)
        {
            DotCEP.Endereco enderecoBase = new DotCEP.Endereco();

            enderecoBase = DotCEP.Consultas.ObterEnderecoCompleto(CEP);

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleVerde();
            Console.WriteLine(String.Format("Estado:{0}", enderecoBase.uf));

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleVerde();
            Console.WriteLine(String.Format("Municipio:{0}", enderecoBase.localidade));


            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleVerde();
            Console.WriteLine(String.Format("Bairro:{0}", enderecoBase.bairro));

            setarCorConsoleAzul();
            Console.WriteLine("-----------");

            setarCorConsoleVerde();
            Console.WriteLine(String.Format("Rua:{0}", enderecoBase.logradouro));

            setarCorConsoleBranco();
        }

        #region CoresDoConsole

        private static void setarCorConsoleAzul()
        {
            Console.ForegroundColor = ConsoleColor.Blue;  
        }

        private static void setarCorConsoleBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void setarCorConsoleAmarelo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        private static void setarCorConsoleVerde()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        #endregion
    }
}
