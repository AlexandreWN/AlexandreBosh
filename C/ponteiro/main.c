#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    /*
    int numero1=1;
    int numero2=2;
    char letra1='a';
    char letra2='b';
    float floati=2.0;
    double doublee=2.60;

    int teste[10];

    printf("Valor1\n");
    printf("%d\n", numero1);
    printf("%d\n\n", &numero1);

    printf("Valor2\n");
    printf("%d\n", numero2);
    printf("%d\n\n", &numero2);

    printf("letra1\n");
    printf("%c\n", letra1);
    printf("%d\n\n", &letra1);

    printf("letra2\n");
    printf("%c\n", letra2);
    printf("%d\n\n", &letra2);

    printf("floati\n");
    printf("%f\n", floati);
    printf("%d\n\n", &floati);

    printf("letra2\n");
    printf("%lf\n", doublee);
    printf("%d\n\n", &doublee);

    printf("vetor\n");
    printf("%d\n", teste);
    printf("%d\n\n", &teste[0]);

    printf("numero1: %d bytes\n", sizeof(numero1));
    printf("numero1: %d bytes\n", sizeof(numero2));
    printf("letra1: %d bytes\n", sizeof(letra1));
    printf("letra1: %d bytes\n", sizeof(letra2));
    printf("floati: %d bytes\n", sizeof(floati));
    printf("doublee: %d bytes\n", sizeof(doublee));
    printf("vetor: %d bytes\n", sizeof(teste));
    */
    /*
    int inteiro=2;
    double doub=2.60;

    int *inteir = &inteiro;
    double *doube = &doub;



    printf("endereco int: %d\n",&inteiro);
    printf("endereco double: %d\n",&doub);
    printf("valor int: %d\n",*inteir);
    printf("valor double: %lf\n",*doube);
    printf("apontando endereco ponteiro int: %d\n",inteir);
    printf("apontando endereco ponteiro double: %d\n",doube);

    inteir = NULL;
    doube = NULL;

    printf("valor int NULL: %d\n",inteir);
    printf("valor double NULL: %d\n",doube);
    */

    int a = 0, b = 0, c = 0;
    int *ab = &a;
    int *bc = &b;
    int *cd = &c;

    printf("Digite o numero1: ");
    scanf("%d",ab);

    printf("Digite o numero2: ");
    scanf("%d",bc);

    printf("Digite o numero3: ");
    scanf("%d",cd);

    printf("numero1: %d\n",*ab);
    printf("numero2: %d\n",*bc);
    printf("numero3: %d\n",*cd);

}
