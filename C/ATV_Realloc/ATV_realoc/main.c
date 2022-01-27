#include <stdio.h>
#include <stdlib.h>

int main(){
    /*Declaração de variaveis*/
    int i, tam, *vet, numero, temp = 1;
    /*Declarar quantos numeros quer adicionar*/
    printf("Digite a quantidade de numeros que quer adicionar: ");
    scanf("%d", &tam);
    /*cria vetor*/
    vet = malloc(temp * sizeof(int));
    /*recebe numeros e aumenta o tamnho do vetor com o realloc*/
    if(vet){
        for(i = 0; i < tam; i++){
            printf("Digite um numero: ");
            scanf("%d", &numero);
            *(vet + i) = numero;
            vet = realloc(vet, temp);
            printf("Memoria alocada com sucesso!\n");
        }
    /*printa os valores do vetor*/
        printf("Seus valores foram: \n");
        for(i = 0; i < tam; i++)
            printf("%d ", *(vet + i));
        printf("\n");
    }
    /*mostra caso de erro ao alocar*/
    else{
        printf("Erro ao alocar memoria!\n");
    }
    free(vet);
    return 0;
}
