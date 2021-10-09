#include<stdio.h>
#include<stdlib.h>
/******************************************************************************/
/******************************************************************************/
typedef void (*ptrMyText)();
typedef int (*ptrMyComp)(int, int);
/******************************************************************************/
/******************************************************************************/
void MyText();
void MyText1();
void MyText2();
int MyAdd(int, int);
int MyMul(int, int);
int MySub(int, int);
/******************************************************************************/
/******************************************************************************/
void MyText(){
    printf("\n\n************* MyText ***********\n");
    printf("******************    ");
    MyText1();
    printf("******************    ");
    MyText2();
    }
/******************************************************************************/
void MyText1(){
    printf("---------> MyText1\n");
    }
/******************************************************************************/
void MyText2(){
    printf(">>>>>>>>>> MyText2\n");
    }
/******************************************************************************/
int MyAdd(int x, int y){
    return x + y;
    }
/******************************************************************************/
int MyMul(int x, int y){
    return x * y;
    }
/******************************************************************************/
int MySub(int x, int y){
    return x - y;
    }
/******************************************************************************/
/******************************************************************************/
int main(){
    ptrMyComp* mT;
    unsigned sT = 6, i;
    mT = (ptrMyComp*) malloc(sizeof(ptrMyComp)*sT);

    mT[0] = MyAdd;
    mT[1] = MyMul;
    mT[2] = MyMul;
    mT[3] = MyAdd;
    mT[4] = MySub;
    mT[5] = MySub;

    for(i=0; i<sT;++i)
        printf("res = %d\n",mT[i](i,5));

    return 0;
    }
