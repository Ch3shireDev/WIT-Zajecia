#include <stdio.h>
/************************************************************************/
/************************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic();
void MyText();
int MyAbs(int);
int MyAdd(int, int);
int MyComp(int, int);
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
int MyComp(int x, int y){
    return 2*x - y;
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
    printf("suma = %d\n",MyComp(MyRead(), MyRead()));

    return 0;
    }
