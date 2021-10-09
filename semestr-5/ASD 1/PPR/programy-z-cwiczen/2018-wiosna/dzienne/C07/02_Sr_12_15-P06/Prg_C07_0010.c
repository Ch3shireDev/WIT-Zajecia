#include <stdio.h>
/************************************************************************/
/************************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic();
void MyText();
int MyAbs(int);
int MyAdd(int, int);
int MyRead();
/************************************************************************/
/************************************************************************/
void MyText(){
    KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic();
    }
/************************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic(){
    printf("Konstantynopolitanczykowianeczka");
    printf(" z Konstantynopola Krakowa i Okolic");
    }
/************************************************************************/
int MyAbs(int x){
    if(x<0) return -x;
    return  x;
    }
/************************************************************************/
int MyAdd(int x, int y){
    return x + y;
    }
/************************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/************************************************************************/
/************************************************************************/
int main(){
    int x =12, y = -9;

    printf("%d + %d = %d\n", x, y, MyAdd(x,y));
    return 0;
    }
