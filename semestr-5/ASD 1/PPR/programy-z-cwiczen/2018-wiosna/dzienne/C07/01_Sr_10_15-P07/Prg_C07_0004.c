#include <stdio.h>
/**************************************************************/
/**************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa();
void MyText();
void MyAbs(int x);
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
void MyAbs(int x){
    if(x<0){
        printf("|%d| = %d\n", x, -x);
        }
    else{
        printf("|%d| = %d\n", x, x);
        }
    }
/**************************************************************/
/**************************************************************/
int main(){


    MyAbs(-10);



    return 0;
    }
