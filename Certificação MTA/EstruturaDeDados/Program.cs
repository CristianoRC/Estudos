using System;
using System.Collections.Generic;

namespace EstruturaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            var fila = new Fila();
            Console.WriteLine($"Tamanho da fila: {fila.Tamanho}");

            var funcionarioUm = new Funcionario("Cristiano Cunha", 2500);
            var funcionarioDois = new Funcionario("Cunha", 1200);

            fila.Enfileirar(funcionarioUm);
            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho}, Primeiro: {fila.Primeiro.Nome}, {fila.Primeiro.Salario}R$");

            fila.Enfileirar(funcionarioDois);
            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho}, Primeiro: {fila.Primeiro.Nome}, {fila.Primeiro.Salario}R$");

            var lista = fila.Listar();

            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho}");

            fila.Desenfileirar();
            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho}, Primeiro: {fila.Primeiro.Nome}, {fila.Primeiro.Salario}R$");

            fila.Desenfileirar();
            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho}");
            fila.Desenfileirar();

            #region  pilha
            /*var pilha = new Pilha();
            Console.WriteLine($"Tamanho da pilha: {pilha.Tamanho}");

            var funcionarioUm = new Funcionario("Cristiano Cunha", 2500);
            var funcionarioDois = new Funcionario("Cunha", 1200);

            pilha.Empilhar(funcionarioUm);
            Console.WriteLine($"\nTamanho da pilha: {pilha.Tamanho}, valor inserido: {pilha.ValorNoTopo.Nome}, {pilha.ValorNoTopo.Salario}R$");

            pilha.Empilhar(funcionarioDois);
            Console.WriteLine($"\nTamanho da pilha: {pilha.Tamanho}, valor inserido: {pilha.ValorNoTopo.Nome}, {pilha.ValorNoTopo.Salario}R$");

            var lista = pilha.Listar();

            Console.WriteLine($"\nSoma dos salários: {pilha.SomarSalarios()}R$");

            Console.WriteLine($"\n\nTamanho da pilha: {pilha.Tamanho}");

            pilha.Desempilhar();
            Console.WriteLine($"\nItem removido da pilha, a pilha ficou com {pilha.Tamanho} iten(s)");

            pilha.Desempilhar();
            Console.WriteLine($"\nItem removido da pilha, a pilha ficou com {pilha.Tamanho} iten(s)"); */
            #endregion
        }
    }
}
