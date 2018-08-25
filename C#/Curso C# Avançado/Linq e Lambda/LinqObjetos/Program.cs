using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuarios = new List<Usuario>();

            usuarios.Add(new Usuario("Cristiano", "contato@cristianoprogramador.com"));
            usuarios.Add(new Usuario("Cristiano Cunha", "lc.cristianocunha@outlook.com"));
            usuarios.Add(new Usuario("José", "contato@gmail.com"));
            usuarios.Add(new Usuario("João", "contato@Gmail.com"));

            var listaFiltrada = usuarios
                .Where(x => x.Email.ToLower().Contains("@gmail.com"))
                .OrderBy(x => x.Nome)
                .Select(x => x.Nome);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
