using System.IO;
using Newtonsoft.Json;

namespace Generics
{
    public static class Serializador
    {
        public static void Serializar(object entrada)
        {
            File.WriteAllText($"{Directory.GetCurrentDirectory()}/{entrada.GetType().Name}.json",
                                JsonConvert.SerializeObject(entrada));
        }

        public static T Desserializar<T>()
        {
            var textoArquivo = File.ReadAllText($"{Directory.GetCurrentDirectory()}/{typeof(T).Name}.json");

            return JsonConvert.DeserializeObject<T>(textoArquivo);
        }
    }
}