//------drzewo.h----------------------------------------------
struct Elem
{
 int dane;
int licznik;
struct Elem *lewy, *prawy;
};
struct Elem *wstaw_el(struct Elem **korz, int _dana);
void zwolnij_drzewo(struct Elem *korz);
struct Elem *znajdz_el(struct Elem *korz, int _dana);
//------drzewo.cpp--------------------------------------------
#include "drzewo.h"
#include <stdio.h>
#include <stdlib.h>
struct Elem *wstaw_el(struct Elem **korz, int _dana)
{
 struct Elem *nowy, *p, *pop;
p=*korz;
while(p){
if(p->dane==_dana){
p->licznik++;
return p;
}else{
pop=p;
if(p->dane>_dana) p=p->lewy;
else p=p->prawy;
}
}
if((nowy=(struct Elem*)malloc(sizeof(struct Elem)))==NULL)
return NULL;
nowy->lewy=nowy->prawy=NULL;
nowy->dane=_dana;
nowy->licznik=0;
if(!*korz) *korz=nowy;
else if(pop->dane>_dana) pop->lewy=nowy;
else pop->prawy=nowy;
return nowy;
}
void zwolnij_drzewo(struct Elem *korz)
{
 if(korz){
zwolnij_drzewo(korz->lewy);
zwolnij_drzewo(korz->prawy);
free(korz);
}
}
struct Elem *znajdz_el(struct Elem *korz, int _dana)
{
 while(korz){
if(korz->dane==_dana){
return korz;
}else{
if(korz->dane>_dana) korz=korz->lewy;
else korz=korz->prawy;
}
}
return NULL;
}
