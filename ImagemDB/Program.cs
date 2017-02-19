using System;

namespace ImagensDB
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			GerarCabessalho();

			setarCorConsoleAmarelo();
			Console.Write("Digite B para buscar informações sobre um usuário ou C para cadastrar:");
			setarCorConsoleBranco();
			var resultado = Console.ReadLine();

			if (resultado == "B")
			{
				Console.Clear();
				BuscarPessoa();
			}
			else if (resultado == "C")
			{
				Console.Clear();
				CadastrarPessoa();
			}

			Console.ReadKey();
		}

		private static void CadastrarPessoa()
		{
			GerarCabessalho();

			Pessoa pessoaBase = new Pessoa();

			setarCorConsoleAmarelo();
			Console.Write("Nome:");
			setarCorConsoleBranco();
			pessoaBase.Nome = Console.ReadLine();

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("CPF:");
			setarCorConsoleBranco();
			pessoaBase.CPF = Convert.ToUInt32(Console.ReadLine());

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("CEP:");
			setarCorConsoleBranco();
			pessoaBase.CEP = Convert.ToUInt32(Console.ReadLine());
			mostrarInformacoesDoCEP(pessoaBase.CEP.ToString());

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("Imagen:");
			//TODO: var caminhoImagem = Console.ReadLine();
			//TODO: pessoaBase.Imagen = Convert_Imagem_Bytes.ConverterParaString(caminhoImagem);
			pessoaBase.Imagen = "TesteImagem";

			pessoaBase.CadastrarPessoa(pessoaBase);


			Console.WriteLine("\n");
			setarCorConsoleVermelho();
			Console.WriteLine("Pessoa Cadastrada com sucesso!\nPressione um botão para finalizar.");

		}

		private static void BuscarPessoa()
		{
			setarCorConsoleAmarelo();
			Console.Write("CPF para efetuar a busca:");
			setarCorConsoleBranco();
			uint CPFparaBusca = Convert.ToUInt32(Console.ReadLine());

			Console.Clear();
			GerarCabessalho();
			Pessoa pessoaBase = new Pessoa();

			pessoaBase = pessoaBase.BuscarPessoa(CPFparaBusca);

			setarCorConsoleAmarelo();
			Console.Write("Nome:");
			setarCorConsoleBranco();
			Console.Write(pessoaBase.Nome);

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("CPF:");
			setarCorConsoleBranco();
			Console.Write(pessoaBase.CPF);

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("CEP:");
			setarCorConsoleBranco();
			Console.Write(pessoaBase.CEP);
			mostrarInformacoesDoCEP(pessoaBase.CEP.ToString());

			Console.WriteLine("\n");

			setarCorConsoleAmarelo();
			Console.Write("Imagen:");

			Console.WriteLine("\n");
			setarCorConsoleVermelho();
			Console.WriteLine("Pessoa carregada com sucesso!\nPressione um botão para finalizar.");

		}

		private static void mostrarInformacoesDoCEP(string CEP)
		{
			DotCEP.Endereco enderecoBase = new DotCEP.Endereco();

			enderecoBase = DotCEP.Consultas.ObterEnderecoCompleto(CEP);

			Console.WriteLine("\n");

			setarCorConsoleVerde();
			Console.WriteLine(String.Format("Estado:{0}", enderecoBase.uf));

			Console.WriteLine(String.Format("Municipio:{0}", enderecoBase.localidade));

			Console.WriteLine(String.Format("Bairro:{0}", enderecoBase.bairro));

			Console.WriteLine(String.Format("Rua:{0}", enderecoBase.logradouro));

			setarCorConsoleBranco();
		}

		private static void GerarCabessalho()
		{
			Console.Clear();
			setarCorConsoleAzul();
			Console.WriteLine("\t\t\t\tImagens no Banco de Dados C#\n\n\n");
		}

		#region Cores Do Console

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

		private static void setarCorConsoleVermelho()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
		}

		#endregion
	}
}
