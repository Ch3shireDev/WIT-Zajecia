#include <stdio.h>
/************************************************************************/
/************************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic();
void MyText();
int MyAbs(int x);
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
    else    return  x;
    }
/************************************************************************/
/************************************************************************/
int main(){
    int y = -9;
    int myAbs;

    myAbs=MyAbs(y);
    printf("|%d| = %d\n", y, myAbs);
    return 0;
    }
