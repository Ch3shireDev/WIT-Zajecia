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
void MySortV(int* a, int* b, int* c){
    if(*a>*b) MySwap(a,b);
    if(*b>*c) MySwap(c,b);
    if(*a>*b) MySwap(a,b);
    }
///************************************************************
///************************************************************
int main(){
    int x, y, z;

    x=MyRead("x? = ");
    y=MyRead("y? = ");
    z=MyRead("z? = ");

    printf("x = %d, y = %d, z = %d\n",x,y,z);
    MySortV(&x, &y, &z);
    printf("x = %d, y = %d, z = %d\n",x,y,z);

    return 0;
    }





