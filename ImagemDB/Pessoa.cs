using System;

namespace ImagensDB
{
	public class Pessoa
	{
		public uint CPF { get; set; }

		public uint CEP { get; set; }

		public String Nome { get; set; }

		public String Imagen { get; set; }

		public void CadastrarPessoa(Pessoa p_informacoesPessoa)
		{
			var CaminhoDoBanco = AppDomain.CurrentDomain.BaseDirectory +
										  "/pessoas.db";
			Spartacus.Database.Command cmd = new Spartacus.Database.Command();
			Spartacus.Database.Generic database;

			cmd.v_text = "insert into usuarios values(#CPF#,#NOME#,#CEP#,#IMAGEM#)";

			cmd.AddParameter("CPF", Spartacus.Database.Type.BIGINTEGER);
			cmd.AddParameter("NOME", Spartacus.Database.Type.STRING);
			cmd.AddParameter("CEP", Spartacus.Database.Type.BIGINTEGER);
			cmd.AddParameter("IMAGEM", Spartacus.Database.Type.STRING);

			cmd.SetValue("CPF", p_informacoesPessoa.CPF.ToString());
			cmd.SetValue("NOME", p_informacoesPessoa.Nome);
			cmd.SetValue("CEP", p_informacoesPessoa.CEP.ToString());
			cmd.SetValue("IMAGEM", p_informacoesPessoa.Imagen);


			try
			{
				database = new Spartacus.Database.Sqlite(CaminhoDoBanco);

				database.Execute(cmd.GetUpdatedText());
			}
			catch (Spartacus.Database.Exception ex)
			{
				throw new Exception(ex.v_message);
			}
		}

		public Pessoa BuscarPessoa(uint p_CPF)
		{
			var CaminhoDoBanco = AppDomain.CurrentDomain.BaseDirectory +
										  "/pessoas.db";
			Spartacus.Database.Command cmd = new Spartacus.Database.Command();
			Spartacus.Database.Generic database;

			cmd.v_text = "select * from usuarios where CPF = #CPF#";

			cmd.AddParameter("CPF", Spartacus.Database.Type.BIGINTEGER);

			cmd.SetValue("CPF", p_CPF.ToString());

			try
			{
				database = new Spartacus.Database.Sqlite(CaminhoDoBanco);

				return database.QueryList<Pessoa>(cmd.GetUpdatedText())[0];
			}
			catch (Spartacus.Database.Exception ex)
			{
				throw new Exception(ex.v_message);
			}
		}
	}
}

