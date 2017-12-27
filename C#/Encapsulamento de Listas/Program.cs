using System;
using System.Collections.Generic;

namespace Encapsulamento_de_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Cristiano Raffi Cunha");

            var produto1 = new Produto(1, "Computador", 2500m);
            var produto2 = new Produto(2, "Celular", 980m);
            var produto3 = new Produto(3, "Xbox 360", 1000m);
            var produto4 = new Produto(4, "PS4", 1900m);
            var produto5 = new Produto(5, "Forza 7", 250m);
            var produto6 = new Produto(6, "FIFA 18", 200m);
            var produtos = new List<Produto> { produto3, produto4, produto5, produto6 };

            var venda = new Venda(cliente);
            venda.AdicionarProduto(produto1);
            venda.AdicionarProduto(produto2);
            listarProdutos();

            Console.Write("\nVocê deseja adicionar outros produtos?");
            var listarMais = Convert.ToBoolean(Console.ReadLine());

            if (listarMais)
            {
                venda.AdicionarProdutos(produtos);
                listarProdutos();
            }


            #region Função Listar Produtos
            void listarProdutos()
            {
                Console.Clear();

                foreach (var prod in venda.Produtos)
                {
                    Console.WriteLine($"Código: {prod.Codigo} | Nome: {prod.Nome} | Valor: {prod.Valor}R$");
                }
            }
            #endregion
        }
    }
}
