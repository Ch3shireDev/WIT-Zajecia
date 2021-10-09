#include <stdio.h>
#include <stdlib.h>
/********************************************************************/
/********************************************************************/
int MyRead();

/********************************************************************/
/********************************************************************/
int main(){
    char* myStr;
    int i;
    myStr=(char*)malloc(sizeof(char)*20);

    myStr[0]= 'A';
    myStr[1]= 'l';
    myStr[2]= 'a';
    myStr[3]= ' ';
    myStr[4]= 'm';
    myStr[5]= 'a';
    myStr[6]= ' ';
    myStr[7]= 'k';
    myStr[8]= 'o';
    myStr[9]= 't';
    myStr[10]= 'a';
    myStr[12]= '\0';
    myStr[19]= 'X';

    myStr[13]= 'k';
    myStr[14]= 'o';
    myStr[15]= 't';
    myStr[16]= 'a';
    myStr[17]= '\0';


    for(i=0;i<20; ++i)
        printf("%c",myStr[i]);
    printf("\n%s\n", myStr);

    printf("\n%s\n", myStr+13);



    return 0;
    }
