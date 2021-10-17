#include <stdio.h>
#include <stdlib.h>
/**************************************************************/
int MyStrLen(char*);
/**************************************************************/
int MyStrLen(char* myStr){
    int i=0;

    if(myStr==NULL) return 0;
    while(myStr[i]!='\0') ++i;
    return i;
    }
/**************************************************************/
/**************************************************************/
int main(){
    char* myStr0 = "KonstantynopoliTanczyKowianeczka";
    char* myStr1 = "Ala ma kota";
    char* myStr2 = (char*)malloc(sizeof(char)*30);
    char* myStr3;
    int i;

    for(i=0;i<30;++i)
        myStr2[i]='X';
    printf("%d\n",myStr2);
    free(myStr2);
    myStr2 = (char*)malloc(sizeof(char)*12);
    printf("%d\n",myStr2);


    for(i=0;i<11;++i)
        myStr2[i]=myStr1[i];

    printf("\nmyStr2 - for loop: ");

    for(i=0;i<11;++i)
        printf("%c",myStr2[i]);

    printf("\nmyStr2 - string: %s\n",myStr2);
    myStr2[i]='\0';
    myStr2[i]=(char)0;
    printf("\nmyStr2 - string: %s\n",myStr2);
    printf("\nmyStr1 - string: %s\n",myStr1);

    myStr3 = (char*)malloc(sizeof(char)*100);

    printf("\nLen(myStr1)=%d\n",MyStrLen(myStr1));

    for(i=0;myStr0[i]!='\0';++i)
        if(myStr0[i]>='A' && myStr0[i]<='Z')
            printf("%c",myStr0[i]);
    printf("\n");

    return 0;
    }
