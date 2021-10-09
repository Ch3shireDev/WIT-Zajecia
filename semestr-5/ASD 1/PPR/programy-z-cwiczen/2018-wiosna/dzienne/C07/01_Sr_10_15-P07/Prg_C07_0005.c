#include <stdio.h>
/**************************************************************/
/**************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa();
void MyText();
int MyAbs(int x);
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
    if(x<0){
        return -x;
        }
    else{
        return x;
        }
    }
/**************************************************************/
/**************************************************************/
int main(){


    printf("|-10| = %d\n",MyAbs(-10));



    return 0;
    }
