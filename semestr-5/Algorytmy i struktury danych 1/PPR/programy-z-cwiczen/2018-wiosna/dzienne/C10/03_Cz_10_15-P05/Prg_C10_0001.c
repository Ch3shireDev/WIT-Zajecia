#include <stdio.h>
#include <stdlib.h>
/*********************************************************/
/*********************************************************/
int MyRead(char * myStr);
/*********************************************************/
/*********************************************************/
int MyRead(){
    int x;
    printf("%s", myStr);
    scanf("%d", &x);

    return x;
    }
/*********************************************************/
/*********************************************************/
int main(){
    char* myStr;
    int i;
    char* aQq="Ale mam qq";



    myStr=(char*)malloc(sizeof(char)*1024);

    for(i=0;i<1024;++i)
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
        printf("%c",myStr[i]);

    printf("\n");
    printf("%s",myStr);
    printf("\n");

    i=0;
    while(myStr[i++]!='\0');
    printf("%s",myStr+i);
    printf("\n");

    while(myStr[i++]!='\0');
    printf("%s",myStr+i);
    printf("\n");
    printf("%s",aQq);

    return 0;
    }
