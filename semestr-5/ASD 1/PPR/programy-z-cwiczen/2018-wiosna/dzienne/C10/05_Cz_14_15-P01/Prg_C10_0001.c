#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead();
/*********************************************************/
/*********************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    char* mT;
    int i;

    mT=(char*)malloc(sizeof(char)*1024);

    for(i=0;i<1024;++i)
        mT[i]='_';


    mT[0]='A';
    mT[1]='l';
    mT[2]='a';
    mT[3]='\0';
    mT[4]='m';
    mT[5]='a';
    mT[6]='\0';
    mT[7]='k';
    mT[8]='o';
    mT[9]='t';
    mT[10]='a';
    mT[11]='\0';


    for(i=0;i<16;++i)
        printf("%c",mT[i]);
    printf("\n");
    printf("%s ",mT);
    i=0;
    while(mT[i++]!='\0');
    printf("%s ",mT+i);
    while(mT[i++]!='\0');
    printf("%s ",mT+i);

    return 0;
    }







