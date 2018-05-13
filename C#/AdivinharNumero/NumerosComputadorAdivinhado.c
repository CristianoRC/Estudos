#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void main()
{
    int valorMaximo = 100;
    int valorMinimo = 0;
    int valorPergunta = (valorMaximo - valorMinimo) / 2;
    int tentaivas = 0;
    char resposta = ' ';
    bool valorEcontrado = false;

    //system("cls");
    system("clear");
    printf("Olá, bem vindo, eu sou capaz de adivinhar o numero que voce esta pensando!\n");
    printf("Pense em um numero Natual de 0 a 100.\n\n\n");

    do
    {
        printf("\nO valor que esta pensando e >, < ou = a %d? ", valorPergunta);
        scanf(" %c", &resposta);

        switch (resposta)
        {
        case '>':
            valorMinimo = ++valorPergunta;
            valorPergunta = valorMinimo + ((valorMaximo - valorMinimo) / 2);
            break;
        case '<':
            valorMaximo = --valorPergunta;
            valorPergunta = valorMaximo - ((valorMaximo - valorMinimo) / 2);
            break;
        case '=':
            valorEcontrado = true;
            break;
        default:
            printf("O caractere \'%c\' e invalido!\n", resposta);
            break;
        }

        tentaivas++;
    } while (!valorEcontrado);

    printf("Encontrei! o valor que você estava pensando era o %d.\n", valorPergunta);
    printf("Foram %d tentativas para chegar nesse valor.\n\n", tentaivas);
}