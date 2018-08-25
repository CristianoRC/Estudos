namespace Generics
{
    public class Carro
    {
        public Carro()
        {
        }

        public Carro(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;

        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}