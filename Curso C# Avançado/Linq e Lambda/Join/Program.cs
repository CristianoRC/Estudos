using System;
using System.Collections.Generic;
using System.Linq;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var autores = new List<Autor>();
            autores.Add(new Autor("Cristiano Raffi Cunha"));
            autores.Add(new Autor("Jeff Sutherland"));

            var livros = new List<Livro>();
            livros.Add(new Livro(autores[0].ID, "Boas práticas na programação", 2020));
            livros.Add(new Livro(autores[0].ID, "Como construir uma carreira de sucesso", 2023));
            livros.Add(new Livro(autores[1].ID, "SCRUM a arte de fazer o dobro na metade do tempo", 2016));

            var listaJoin = from livro in livros
                            join autor in autores
                            on livro.IDAutor equals autor.ID
                            select new { Autor = autor.Nome, TituloLivro = livro.Titulo };


            foreach (var item in listaJoin)
            {
                Console.WriteLine($"Livro {item.TituloLivro} - {item.Autor}");
            }
        }
    }
}
