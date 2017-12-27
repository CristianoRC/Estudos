namespace Encapsulamento_de_Listas
{
    public class Produto
    {
        public Produto(int codigo, string nome, decimal valor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Valor = valor;

            if (string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Produto inválido");
            }
        }

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
    }
}