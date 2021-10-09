#include <stdio.h>
#include <stdlib.h>
/*********************************************************************************/
void* MyStruct(int, double, char);
void* PrintMyStruct(void*);
double* NewTabDouble(unsigned);
unsigned PrintTabDouble(double*);
/*********************************************************************************/
/*********************************************************************************/
void* MyStruct(int sI, double sD, char sC){
    void* myS = malloc(sizeof(int)+sizeof(double)+sizeof(char));
    void* tmP = myS;
    *((int*)tmP) = sI;
    tmP = (int*)tmP+1;
    *((double*)tmP)= sD;
    tmP = (double*)tmP+1;
    *((char*) tmP)= sC;
    return myS;
    }
/*********************************************************************************/
void* PrintMyStruct(void* myS){
    void* tmP = myS;
    printf("sI = %d, ",*(int*)tmP);
    tmP = (int*)tmP+1;
    printf("sD = %f, ",*(double*)tmP);
    tmP = (double*)tmP+1;
    printf("sC = %c\n",*(char*)tmP);
    return myS;
    }
/*********************************************************************************/
double* NewTabDouble(unsigned sT){
    double* myT, *bT;
    int i;
    bT=myT=(double*)malloc(sizeof(double)*sT+sizeof(unsigned));
    for(*((unsigned*)myT++) = sT,i=0;i<sT;myT[i]=2*i,++i);
    return bT;
    }
/*********************************************************************************/
unsigned PrintTabDouble(double* myT){
    int i, sT;
    for(sT=*(unsigned*)myT++,i=0;i<sT;printf("T[%3u]=%4lf\n",i,myT[i++]));
    return sT;
    }
/*********************************************************************************/
/*********************************************************************************/
int main(){
    void * myX = MyStruct(3,12.6,'a');
    double* myT = NewTabDouble(10);
    PrintMyStruct(myX);
    PrintTabDouble(myT);
    return 0;
    }

