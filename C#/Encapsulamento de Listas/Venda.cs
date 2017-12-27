using System.Collections.Generic;
using System.Linq;

namespace Encapsulamento_de_Listas
{
    public class Venda
    {
        IList<Produto> _produtos;

        public Venda(Cliente cliente)
        {
            Cliente = cliente;
            _produtos = new List<Produto>();
        }

        public Cliente Cliente { get; private set; }
        public IReadOnlyCollection<Produto> Produtos { get => _produtos.ToArray(); }

        public void AdicionarProdutos(IList<Produto> produtos)
        {
            _produtos = _produtos.Concat(produtos).ToList();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }
    }
}