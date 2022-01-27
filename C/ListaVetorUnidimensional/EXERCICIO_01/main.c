#include <stdio.h>
#include <stdlib.h>
#define DEZ 10

int main(void){
    float valor[DEZ], totalproduto, totalvenda = 0, comissao;
    int qtd[DEZ], i, j;
    for( i = 0 ; i < DEZ ; i++ ){
        printf("\nDigite o valor e a quantidade de vendas do produto %i: ", i + 1);
            scanf("%f %i", &valor[i], &qtd[i]);
    }

    for( i = 0 ; i < DEZ ; i++ ){
        printf("\n\nA quantidade de vendas do produto %2i e de: %i: ", (i + 1), qtd[i]);
        printf("\nO valor unitario do produto %2i e: %.2f.", (i + 1), valor[i]);
        totalproduto = 0;
        for( j = 0 ; j < qtd[i] ; j++ ){
            totalproduto = totalproduto + valor[i];
        }
        printf("\nO valor total do produto %2i e: %.2f: ", (i + 1), totalproduto);
        totalvenda = totalvenda + totalproduto;
    }

    printf("\n\nO valor total da venda e: %.2f.", totalvenda);

    comissao = (totalvenda * 0.05);

    printf("\n\nO valor da comissao do vendedor e: %.2f: ", comissao);
        printf("\n\nO salario total do vendedor foi: %.2f: ",  545.00 + comissao);

    for( i = 0 ; i < DEZ ; i++ ){
        for( j = 0 ; j < DEZ ; j++ ){
            if( qtd[i] < qtd[j] ){
                break;
            }
            else if( j == DEZ - 1 ){
                printf("\n\nO produto mais vendido se localiza na posicao %d do vetor", (i + 1));
            }
        }
    }

    return 0;
}
