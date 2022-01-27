/*Bibliotecas*/
#include <stdio.h>
#include <stdlib.h>
#include "func.h"
#include <locale.h>


int main(){
    /*Variaveis*/
    setlocale(LC_ALL, "");
	struct Pilha minhapilha;
	int capacidade, op;
	float valor;
    /*Capacidade da pilha*/
	printf( "\nDigite a apacidade da pilha:  " );
	scanf( "%d", &capacidade );

	criarpilha (&minhapilha, capacidade);

	while( 1 ){
        /*Parte destina a escolher a fun��o desejada*/
		printf("\n1- empilhar (push) \n");
		printf("2- desempilhar (POP)\n");
		printf("3- Mostrar o topo \n");
		printf("4- Verificar se a pilha est� cheia \n");
		printf("5- Verificar se a pilha est� vazia \n");
		printf("6- sair\n");
		scanf("%d", &op);

		switch (op){
            /*Caso 1 empilha dados*/
			case 1:

				if( estacheia( &minhapilha ) == 1 )

					printf("\nPILHA CHEIA! \n");

				else {

					printf("\nDigite um n�mero para empilhar: ");
					scanf("%f", &valor);
					empilhar (&minhapilha, valor);

				}
				break;
            /*Retira desempilha o ultimo dado*/
			case 2:
				if ( estavazia(&minhapilha) == 1 )

					printf( "\nPILHA VAZIA! \n" );

				else{

					valor = desempilhar (&minhapilha);
					printf ( "\n%.1f DESEMPILHADO!\n", valor );

				}
				break;
            /*Mostra o topo da pilha*/
			case 3: // mostrar o topo
				if ( estavazia (&minhapilha) == 1 )

					printf( "\nA PILHA EST� VAZIA!\n" );

				else {

					valor = retornatopo (&minhapilha);
					printf ( "\nTOPO: %.1f\n", valor );

				}
				break;
            /*Verifica se a pilha est� cheia*/
            case 4:
                if( estacheia( &minhapilha ) == 1 )
                    printf("\nA PILHA EST� CHEIA! \n");
                else{
                    printf("\nA PILHA N�O EST� CHEIA");
                }
                break;
            /*Verifica se a pilha esta vazia*/
            case 5:
                if( estavazia( &minhapilha ) == 1)
                    printf("\nA PILHA EST� VAZIA");
                else
                    {
                    printf("\nA PILHA N�O EST� VAZIA");
                }
                break;
            /*Sair*/
			case 6:
				exit(0);
            /*Retorna op��o invalida*/
			default: printf( "\nOPCAO INVALIDA! \n" );
		}
	}

}
