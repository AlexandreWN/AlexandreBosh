/*Bibliotecas*/
#ifndef FUNC_H_INCLUDED
#define FUNC_H_INCLUDED

#include <stdio.h>
#include <stdlib.h>

/*Pilha*/
struct Pilha {

	int topo;
	int capa;
	float *pElem;

};
/*Criar pilha*/
void criarpilha( struct Pilha *p, int c ){

   p->topo = -1;
   p->capa = c;
   p->pElem = (float*) malloc (c * sizeof(float));

}

/*Verifica se a pilha ta vazia*/
int estavazia ( struct Pilha *p ){

   if( p-> topo == -1 )

      return 1;

   else

      return 0;

}
/*Verifica se a pilha ta cheia*/
int estacheia ( struct Pilha *p ){

	if (p->topo == p->capa - 1)

		return 1;

	else

		return 0;

}
/*Insere itens na pilha*/
void empilhar ( struct Pilha *p, float v){

	p->topo++;
	p->pElem [p->topo] = v;

}
/*Retira itens da pilha*/
float desempilhar ( struct Pilha *p ){

   float aux = p->pElem [p->topo];
   p->topo--;
   return aux;

}
/*Retorna o topo da pilha*/
float retornatopo ( struct Pilha *p ){

   return p->pElem [p->topo];

}


#endif // FUNC_H_INCLUDED



