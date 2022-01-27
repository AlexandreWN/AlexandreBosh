#include <stdio.h>
#include <stdlib.h>

int main(){
   //variaveis
   int i, j, aux, vet[8], num = 0, cont = 0;

   for(i=0; i<8; i++)
       vet[i] = 0;
   aux = 0;
   //PREENCHER E EXIBIR VETOR
   for(i=0; i< 8; i++){
       printf("Digite o numero %d", i + 1);
       scanf("%d", &num);
       if(cont = 0){
         vet[i] = num;

       }
       else{
            for(i=0; i<sizeof(vet); i++){
               for(j=0; j<sizeof(vet) - 1; j++){
                   if(vet[i] < vet[j])
                   {
                       aux = vet[j];
                       vet[j] = vet[i];
                       vet[i] = aux;
                   }
                }
           }
       }
        cont++;
   }
   return 0;
}
