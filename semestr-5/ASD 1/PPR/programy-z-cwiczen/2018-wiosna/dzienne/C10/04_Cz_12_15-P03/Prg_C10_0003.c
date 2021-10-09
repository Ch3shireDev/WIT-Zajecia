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
    scanf("%d",&x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    char * myStr;
    char * myStr2= "Ale mam qq";
    int i;
    myStr = (char*)malloc(sizeof(char)*1024);

    for(i=0; i<1024;++i)
        myStr[i]='_';

    myStr[0]='A';
    myStr[1]='l';
    myStr[2]='a';
    myStr[3]='\0';
    myStr[4]='m';
    myStr[5]='a';
    myStr[6]='\0';
    myStr[7]='k';
    myStr[8]='o';
    myStr[9]='t';
    myStr[10]='a';
    myStr[11]='\0';

    for(i=0;i<20;++i)
        printf("%c", myStr[i]);
    printf("\n*****************\n");


    printf("%s\n", myStr);
    i=0;
    while(myStr[i++]!='\0');
    printf("%s\n", myStr+i);
    while(myStr[i++]!='\0');
    printf("%s\n", myStr+i);
    return 0;
    }







