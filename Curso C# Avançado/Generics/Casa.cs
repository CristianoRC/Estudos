namespace Generics
{
    public class Casa
    {
        public Casa()
        {
        }

        public Casa(string cidade, string endereco)
        {
            Cidade = cidade;
            Endereco = endereco;
        }

        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }
}