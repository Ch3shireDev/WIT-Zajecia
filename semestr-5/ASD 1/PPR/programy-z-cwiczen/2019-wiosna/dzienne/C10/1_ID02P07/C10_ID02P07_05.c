///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<string.h>

///**********************************************
int MyRead(char*);
int MyStrLen(char*);
void Upp(char*);
///**********************************************
///**********************************************
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
///**********************************************
int MyStrLen(char* myStr){
    int cnt=0;
    while('\0'!=myStr[cnt++]);
    return --cnt;
    }
///**********************************************
void Upp(char* myStr){
    int i=0;
    while('\0'!=myStr[i]){
        if(myStr[i]>='a' && myStr[i]<='z')
            myStr[i] = (char)((int)'A' - (int)'a' +(int)myStr[i]);
        ++i;
        }
    }
///**********************************************
int main(){
    char* st = "Ala ma kota";
    char* myStr, *myS;

    printf("Len(st) = %d\n", strlen(st));
    printf("Len(st) = %d\n", MyStrLen(st));
    myStr = (char*)malloc((strlen(st)+1)*sizeof(char));
    myS = (char*)malloc(4*sizeof(char));
    for(int i=0; i<=strlen(st);++i)
        myStr[i]=st[i];

    printf("%s\n",myStr);

    for(int i=0; i<=strlen(st);++i)
        printf("int(%c) = %d\n",myStr[i],(int)myStr[i]);

    myS[0] = 'A';
    myS[1] = 'l';
    myS[2] = 'a';
    myS[3] = '\0';

    printf("%s\n",myS);


    Upp(myStr);
    printf("%s\n",myStr);
    return 0;
    }
///2, 3, 4
