///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int* pT;
    int sT;
    }TabX01Int;
///********************************************************
///********************************************************
TabX01Int TabX01IntNew(int sT);
TabX01Int TabX01IntRand(TabX01Int, int, int);
TabX01Int TabX01IntPrint(TabX01Int, int);
///********************************************************
///********************************************************
int MyRead(char*);
///********************************************************
///********************************************************
TabX01Int TabX01IntNew(int sT){
    TabX01Int myT;
    if(sT<1){
        myT.pT=NULL;
        myT.sT=0;
        }
    else{
        myT.pT=(int*)malloc(sizeof(int)*sT);
        myT.sT=sT;
        }
    return myT;
    }
///********************************************************
TabX01Int TabX01IntRand(TabX01Int myT, int a, int b){
    for(int i=0; i<myT.sT;++i)
        myT.pT[i]=rand()%(b-a)+1+a;
    return myT;
    }
///********************************************************
TabX01Int TabX01IntPrint(TabX01Int myT, int s){
    for(int i=0; i<myT.sT;++i)
        printf("[%*d]",s,myT.pT[i]);
    return myT;
    }
///********************************************************
///********************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d", &x);
    return x;
    }
///********************************************************
///********************************************************
int main(){
    srand(time(0));
    TabX01Int myT;
    int sT;
    int a,b;
    sT = MyRead("size of table ? = ");
    a  = MyRead("a? = ");
    b  = MyRead("b? = ");

    myT = TabX01IntNew(sT);
    TabX01IntRand(myT,a,b);
    TabX01IntPrint(myT,2);

    return 0;
    }
