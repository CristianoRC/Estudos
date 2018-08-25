using System;

namespace Join
{
    public class Livro
    {
        public Livro(Guid iDAutor, string titulo, uint anoPublicacao)
        {
            ID = Guid.NewGuid();
            IDAutor = iDAutor;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
        }

        public Guid ID { get; set; }
        public Guid IDAutor { get; set; }
        public string Titulo { get; set; }
        public uint AnoPublicacao { get; set; }


    }
}