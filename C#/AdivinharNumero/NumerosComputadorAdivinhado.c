#include <stdio.h>
#include <stdbool.h>

int main()
{
    int valorMaximo = 100;
    int valorMinimo = 0;
    int valorPergunta = 0;
    int tentaivas = 0;
    char resposta = ' ';
    bool valorEcontrado = false;

    printf("Olá, bem vindo, eu sou capaz de adivinhar o numero que voce esta pensando!\n");
    printf("Pense em um numero Natual de 0 a 100.\n\n");

    do
    {
        valorPergunta = valorMinimo + ((valorMaximo - valorMinimo) / 2);

        if (valorMaximo != valorMinimo)
        {
            printf("\nO valor que esta pensando e >, < ou = a %d? ", valorPergunta);
            scanf(" %c", &resposta);

            switch (resposta)
            {
            case '>':
                valorMinimo = valorPergunta + 1;
                break;
            case '<':
                valorMaximo = valorPergunta - 1;
                break;
            case '=':
                valorEcontrado = true;
                break;
            default:
                printf("O caractere \'%c\' e invalido!\n", resposta);
                break;
            }
        }
        else
        {
            valorEcontrado = true;
        }

        tentaivas++;

    } while (!valorEcontrado);

    printf("Encontrei! o valor que você estava pensando era o %d.\n", valorPergunta);
    printf("Foram %d tentativas para chegar nesse valor.\n\n", tentaivas);

    return 0;
}