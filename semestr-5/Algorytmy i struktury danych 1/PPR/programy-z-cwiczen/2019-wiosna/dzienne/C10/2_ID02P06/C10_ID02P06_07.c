#include<stdio.h>
#include<stdlib.h>
#include<string.h>
///213.135.45.65:7070
///**************************************************
int MyRead(char*);
int MyStrLen(char*);
///**************************************************
///**************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///**************************************************
int MyStrLen(char* sT){
    int cnt = 0;
    while(sT[cnt++]);
    return --cnt;
    }
///**************************************************
///**************************************************
int main(){
    char* sT0 = "Ala ma kota";
    char* sT1;
    int sS = MyStrLen(sT0);

    sT1 = (char*)malloc(sizeof(char)*(sS+1));
    for(int i=0;i<=sS;++i)
        sT1[i] = sT0[i];

    sT1[3]='\0';

    printf("%s\n",sT1);
    printf("%s\n",sT1+MyStrLen(sT1)+1);

    return 0;
    }
///2, 3, 4
