using System;

namespace CRUD
{
    public class Cliente : IDisposable
    {
        public Cliente()
        {
        }

        public Cliente(int codigo)
        {
            //Construtor
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public char? Sexo { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
