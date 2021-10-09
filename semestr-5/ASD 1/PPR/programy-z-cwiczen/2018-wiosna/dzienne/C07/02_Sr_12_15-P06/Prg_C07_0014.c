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
    printf("suma = %d\n",MyAdd(MyRead(), MyRead()));

    return 0;
    }
