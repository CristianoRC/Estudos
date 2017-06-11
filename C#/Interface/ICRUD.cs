using System;
namespace Interface
{
	public interface ICRUD
	{
		bool Create();

		bool Read();

		bool Update();

		bool Delete();
	}
}
