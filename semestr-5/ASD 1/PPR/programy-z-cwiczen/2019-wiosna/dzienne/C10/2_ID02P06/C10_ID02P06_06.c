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
    char z = '\0';
    printf("Len(%s) = %d\n", sT0, strlen(sT0));
    printf("Len(%s) = %d\n", sT0, MyStrLen(sT0));
    for(int i=0; i<=strlen(sT0);++i)
        printf("int(%c) = %d\n",sT0[i], (int)sT0[i]);


    return 0;
    }
///2, 3, 4
