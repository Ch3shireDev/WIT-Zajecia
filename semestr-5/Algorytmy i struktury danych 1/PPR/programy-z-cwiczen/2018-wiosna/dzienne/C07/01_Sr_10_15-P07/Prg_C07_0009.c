#include <stdio.h>
/**************************************************************/
/**************************************************************/
void KonstantynopolitanczykowianeczkazKonstantynopolaiKrakowa();
void MyText();
int MyAbs(int);
int MyAdd(int, int);
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
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/**************************************************************/
/**************************************************************/
int main(){
    int y;

    y= MyRead();

    printf("|%d| + %d = %d\n",y,MyAbs(y), MyAdd(y, MyAbs(y)));



    return 0;
    }
