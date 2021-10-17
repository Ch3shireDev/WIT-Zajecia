///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int* pT;
    int  sT;
    }TabIntX01;
///*******************************************************
///*******************************************************
TabIntX01 TabIntX01New(int);
TabIntX01 TabIntX01Rand(TabIntX01, int, int);
TabIntX01 TabIntX01Print(TabIntX01, int);
///*******************************************************
///*******************************************************
int MyRead(char*);
///*******************************************************
///*******************************************************
TabIntX01 TabIntX01New(int sT){
    TabIntX01 myT;
    if(sT<1){
        myT.pT=NULL;
        myT.sT=0;
        return myT;
        }
    myT.sT=sT;
    myT.pT=(int*)malloc(sizeof(int)*sT);
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Rand(TabIntX01 myT, int a, int b){
    for(int i = 0; i<myT.sT; ++i)
        myT.pT[i] = rand()%(b-a) + a;
    return myT;
    }
///*******************************************************
TabIntX01 TabIntX01Print(TabIntX01 myT, int s){
    for(int i = 0; i<myT.sT; ++i)
        printf("[%*d]",s, myT.pT[i]);
    return myT;
    }
///*******************************************************
///*******************************************************
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
///*******************************************************
///*******************************************************
int main(){
    srand(time(0));
    TabIntX01 myT;
    int sT;
    int a, b;
    sT = MyRead("size of tab ? = ");
    a  = MyRead("a? = ");
    b  = MyRead("b? = ");

    myT = TabIntX01New(sT);
    TabIntX01Rand(myT, a, b);
    TabIntX01Print(myT,2);

    return 0;
    }
