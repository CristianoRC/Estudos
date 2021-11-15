using System;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario("Cristiano", "contato@cristianoprogramador.com", "0123");
            Log.GravarLog(usuario);
            usuario.Nome = "Cristiano Cunha";
            Log.GravarLog(usuario);
            
            Log.ApresentarLog();
        }
    }
}
