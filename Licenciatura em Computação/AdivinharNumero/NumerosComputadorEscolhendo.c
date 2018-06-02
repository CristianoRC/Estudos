#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main()
{
    int valorMaximo, valorEscolhido, valorInserido, valorErro;
    int pontuacao = 100;
    bool valorEcontrado = false;

    printf("Olá, bem vindo, você e capaz de adivinhar o numero que estou pensando?\n");
    printf("Eu posso escolher um numero Natual de 0 a ");
    scanf("%d", &valorMaximo);

    // Cada erro vale 100/nº de termos
    valorErro = pontuacao / valorMaximo;

    // O resto da divisão sempre será menor que o valor que esta sendo dividido;
    //Se valor maximo for igual a 10 ele geraria um numero de 0 a 9, por isso do +1;
    valorEscolhido = rand() % (valorMaximo + 1);

    printf("\n\nEscolhendo um numero ...\n\n");

    do
    {
        printf("\nInsira um valor: ");
        scanf("%d", &valorInserido);

        if (valorEscolhido == valorInserido)
        {
            valorEcontrado = true;
        }
        else if (valorInserido < valorEscolhido)
        {
            printf("O valor inserido e menor que o numero que eu escolhi...\n");
            pontuacao -= valorErro;
        }
        else if (valorInserido > valorEscolhido)
        {
            printf("O valor inserido e maior que o numero que eu escolhi...\n");
            pontuacao -= valorErro;
        }

    } while (!valorEcontrado);
    
    printf("Parabéns voce acertou, o valor era %d e voce ficou com %d pontos de 100.\n\n", valorEscolhido, pontuacao);

    return 0;
}