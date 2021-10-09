#include<stdio.h>
#include<stdlib.h>
/*******************************************************************/
struct{
    int x;
    int y;
    }typedef MyPoint;
/*******************************************************************/
typedef struct{
    MyPoint a;
    MyPoint b;
    }MySegment;
/*******************************************************************/
/*******************************************************************/
MyPoint MyPacking(int, int);
int MyRead(char*);
MyPoint MyDoubleRead(char*, char*);
void MyPointPrint(MyPoint, char*);
MySegment MySegmentRead(char*);
void MySegmentPrint(MySegment, char*);
/*******************************************************************/
/*******************************************************************/
MyPoint MyPacking(int x, int y){
    MyPoint myPoint;

    myPoint.x = x;
    myPoint.y = y;

    return myPoint;
    }
/*******************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d", &x);
    return x;
    }
/*******************************************************************/
MyPoint MyDoubleRead(char* myStr1, char* myStr2){
    MyPoint myPoint;
    myPoint.x=MyRead(myStr1);
    myPoint.y=MyRead(myStr2);
    return myPoint;
    }
/*******************************************************************/
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %d, y = %d", myStr, myPoint.x, myPoint.y);
    }
/*******************************************************************/
MySegment MySegmentRead(char* myStr){
    MySegment mySegment;
    printf("%s", myStr);
    mySegment.a = MyDoubleRead("\na: x ?=", "a: y ?=");
    mySegment.b = MyDoubleRead("\nb: x ?=", "b: y ?=");
    return mySegment;
    }
/*******************************************************************/
void MySegmentPrint(MySegment mySegment, char* myStr){
    printf("%s", myStr);
    MyPointPrint(mySegment.a,"\na :");
    MyPointPrint(mySegment.b,"\nb :");
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MySegment mySegment;
    mySegment = MySegmentRead("\n\t> mySegment:");
    MySegmentPrint(mySegment,"mySegment:");

    return 0;
    }
