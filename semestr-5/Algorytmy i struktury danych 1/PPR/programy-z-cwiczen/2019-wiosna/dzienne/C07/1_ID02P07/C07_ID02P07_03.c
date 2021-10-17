#include <stdio.h>
///************************************************************
int MyRead(char*);
void MySwap(int* , int*);
void MySortV(int*, int*, int*);
///************************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///************************************************************
void MySwap(int* a, int* b){
    int tmp;
    tmp = *a;
    *a = *b;
    *b = tmp;
    }
///************************************************************
///************************************************************
int main(){
    int x, y, z;

    x=12;
    y=7;

    printf("x = %d, y = %d\n",x,y);

    MySwap(&x,&y);

    printf("x = %d, y = %d\n",x,y);

    return 0;
    }
