//------lista.h----------------------------------------------------------
struct El_listy
{
 int dana;
struct El_listy *nast;
};
struct El_listy* mniejszy(struct El_listy* lista, int _dana);
struct El_listy* wstaw_el(struct El_listy** pocz,
struct El_listy* pop,
int _dana);
void zwolnij_liste(struct El_listy** pocz);
struct El_listy* znajdz_el(struct El_listy* lista, int _dana);
void usun_el(struct El_listy** pocz, int _dana);
//------lista.cpp--------------------------------------------------------
#include "lista.h"
#include <stdio.h>
#include <stdlib.h>
struct El_listy *mniejszy(struct El_listy* lista, int _dana)
{
 struct El_listy *pop=NULL;
while((lista!=NULL)&&(lista->dana<_dana)){
pop=lista;
lista=lista->nast;
}
return pop;
}
struct El_listy *wstaw_el(struct El_listy **pocz,
struct El_listy *pop,
int _dana)
{
 struct El_listy *biezacy;
if((biezacy=(struct El_listy*)malloc(sizeof(struct El_listy)))==NULL)
return NULL;
biezacy->dana=_dana;
biezacy->nast=NULL;
if(*pocz==NULL)
*pocz=biezacy;
else
if(pop==NULL){
biezacy->nast=*pocz;
*pocz=biezacy;
}else{
biezacy->nast=pop->nast;
pop->nast=biezacy;
}
return biezacy;
}
void zwolnij_liste(struct El_listy **pocz)
{
 struct El_listy *lista=*pocz;
struct El_listy *_nast;
while(lista!=NULL){
_nast=lista->nast;
free(lista);
lista=_nast;
}
*pocz=NULL;
}


struct El_listy *znajdz_el(struct El_listy *lista, int _dana)
{
 while(lista!=NULL){
if(lista->dana==_dana) return lista;
lista=lista->nast;
}
return NULL;
}
void usun_el(struct El_listy **pocz, int _dana)
{
 struct El_listy *biezacy=*pocz, *pop=NULL;
while(biezacy!=NULL){
if(biezacy->dana!=_dana){
pop=biezacy;
biezacy=biezacy->nast;
}else{
if(biezacy==*pocz) *pocz=biezacy->nast;
else pop->nast=biezacy->nast;
free(biezacy);
}
}
}
