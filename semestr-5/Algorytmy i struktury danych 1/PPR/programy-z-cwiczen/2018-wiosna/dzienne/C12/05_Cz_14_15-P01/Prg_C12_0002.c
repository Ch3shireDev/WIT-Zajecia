#include<stdio.h>
#include<stdlib.h>
/*******************************************************************/
/*******************************************************************/
typedef struct{
    int x;
    int y;
    }MyPoint;
/*******************************************************************/
typedef struct{
    MyPoint A;
    MyPoint B;
    }MySegment;
/*******************************************************************/
/*******************************************************************/
MyPoint MyPointNew(int, int);
MyPoint MyPointRead(char* myStr1, char* myStr2);
void MyPointPrint(MyPoint myPoint, char* myStr);
MyPoint MyPointMove(MyPoint, MyPoint);
/*******************************************************************/
/*******************************************************************/
int MyRead(char*);
/*******************************************************************/
/*******************************************************************/
MyPoint MyPointNew(int x, int y){
    MyPoint myPoint;
    myPoint.x=x;
    myPoint.y=y;
    return myPoint;
    }
/*******************************************************************/
MyPoint MyPointRead(char* myStr1, char* myStr2){
    return MyPointNew(MyRead(myStr1), MyRead(myStr2));
    }
/*******************************************************************/
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %d, y = %d",myStr, myPoint.x, myPoint.y);
    }
/*******************************************************************/
MyPoint MyPointMove(MyPoint p1, MyPoint p2){
    return MyPointNew(p1.x+p2.x, p1.y+p2.y);
    }
/*******************************************************************/
/*******************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MyPoint mP1;
    mP1 = MyPointRead("\tx ?=", "\nmP1:\n\ty ?=");
    MyPointPrint(mP1, "\n************\nmP1:\n\t");
    MyPointPrint(MyPointMove(mP1,MyPointRead("\tx ?=", "\nEmpty:\n\ty ?=")),
                 "\n************\nMoved:\n\t");
    return 0;
    }
