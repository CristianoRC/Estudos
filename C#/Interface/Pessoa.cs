using System;
namespace Interface
{
	public class Pessoa : ICRUD, IUsuario
	{
		public string Nome
		{
			get;
			set;
		}

		public int Idade
		{
			get;
			set;
		}

		public bool Create()
		{
			return true;
		}

		public bool Read()
		{
			return true;
		}

		public bool Update()
		{
			return true;
		}

		public bool Delete()
		{
			return true;
		}


		#region Gerado automaticamente

		/*
		public string Nome
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public int Idade
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}


		public bool Create()
		{
			throw new NotImplementedException();
		}

		public bool Delete()
		{
			throw new NotImplementedException();
		}

		public bool Read()
		{
			throw new NotImplementedException();
		}

		public bool Update()
		{
			throw new NotImplementedException();
		}*/
		#endregion

	}
}
