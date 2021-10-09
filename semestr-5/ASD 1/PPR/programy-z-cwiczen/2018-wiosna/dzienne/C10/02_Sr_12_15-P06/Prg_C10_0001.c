#include <stdio.h>
#include <stdlib.h>
/**************************************************************/
/**************************************************************/
int MyStrLen(char*);
int CapitalLetters(char*);
void MergeStrings(char*, char*, char*);
/**************************************************************/
/**************************************************************/
int MyStrLen(char* myStr){
    int i=0;
    if(NULL==myStr) return -1;
    while('\0'!=myStr[i]) ++i;
    return i;
    }
/**************************************************************/
int CapitalLetters(char* myStr){
    int cnt=0;
    int i=0;
    if(NULL==myStr) return -1;
    while('\0'!=myStr[i]){
        if(myStr[i]>='A' && myStr[i]<='Z'){
            printf("%c", myStr[i]);
            ++cnt;
            }
        ++i;
        }
    return cnt;
    }
/**************************************************************/
void MergeStrings(char* myStr, char* myStr1, char* myStr2){
    int i, j;
    for(i=0;'\0' != myStr1[i]; ++i) myStr[i]= myStr1[i];
    myStr[i]= myStr1[i++];

    for(j=0;'\0' != myStr2[j]; ++i,++j) myStr[i]= myStr2[j];
    myStr[i]= myStr2[j];

    }
/**************************************************************/
/**************************************************************/
int main(){
    char* myStr0 = "KonsTanTynopoliTanczyKowianeczKa++9--==";
    char* myStr1 = "Ala ma kota";
    char* myStr2;
    char* myStr3;
    int i;

    myStr2 = (char*)malloc(sizeof(char)*30);

    for(i=0; i<30;++i)
        myStr2[i] = 'X';

    free(myStr2);


    myStr2 = (char*)malloc(sizeof(char)*12);

    for(i=0; i<11;++i)
        myStr2[i] = myStr1[i];

    printf("myStr2 for loop: ");

    for(i=0; i<11;++i)
        printf("%c", myStr2[i]);
    printf("\n");

    printf("myStr0: %s\n", myStr0);
    printf("myStr1: %s\n", myStr1);
    printf("myStr2: without 0 %s\n", myStr2);
    myStr2[i]='\0';
    printf("myStr2: with    0 %s\n", myStr2);

    printf("\nLen(myStr1) = %d\n",MyStrLen(myStr1));

    printf("myStr0 for loop: ");
    for(i=0; i<MyStrLen(myStr0);++i)
        printf("%c", myStr0[i]);
    printf("\nCapital letters:\n");



    printf("\nNumber of capital letters = %d\n",CapitalLetters(myStr0));
    myStr3 = (char*)malloc(sizeof(char)*100);

    MergeStrings(myStr3,myStr0, myStr1);
    printf("\n***********\nmyStr3: %s\n", myStr3);
    printf("\n***********\nmyStr3: %s\n", myStr3+MyStrLen(myStr0)+1);

    free(myStr3);
    free(myStr2);
    return 0;
    }
