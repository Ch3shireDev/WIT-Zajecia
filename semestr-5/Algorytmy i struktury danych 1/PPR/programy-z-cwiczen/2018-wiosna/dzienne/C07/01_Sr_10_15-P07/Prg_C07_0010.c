#include <stdio.h>
/**************************************************************/
/**************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa();
void MyText();
int MyAbs(int);
int MyAdd(int, int);
int MyComp1(int, int);
int MyRead();
/**************************************************************/
/**************************************************************/
void MyText(){
    KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa();
    }
/**************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa(){
    printf("Konstantynopolitanczykowianeczka");
    printf(" z Konstantynopola i Krakowa");
    }
/**************************************************************/
int MyAbs(int x){
    if(x<0) return -x;
    return x;
    }
/**************************************************************/
int MyAdd(int x, int y){
    return x + y;
    }
/**************************************************************/
int MyComp1(int x, int y){
    return 2*x - y;
    }
/**************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/**************************************************************/
/**************************************************************/
int main(){
    int x, y;

    printf("Abs = %d\n",MyAbs(MyRead()));

    printf("Suma = %d\n",MyComp1(MyRead(),MyRead()));


    return 0;
    }
