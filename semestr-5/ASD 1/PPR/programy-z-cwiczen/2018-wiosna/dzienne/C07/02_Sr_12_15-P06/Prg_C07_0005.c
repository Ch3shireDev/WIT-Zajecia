#include <stdio.h>
/************************************************************************/
/************************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaiOkolic();
void MyText();
void MyAbs(int x);
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
void MyAbs(){
    int x=-9;
    if(x<0) printf("|%d| = %d", x, -x);
    else    printf("|%d| = %d", x,  x);
    }
/************************************************************************/
/************************************************************************/
int main(){
    MyAbs();
    return 0;
    }
