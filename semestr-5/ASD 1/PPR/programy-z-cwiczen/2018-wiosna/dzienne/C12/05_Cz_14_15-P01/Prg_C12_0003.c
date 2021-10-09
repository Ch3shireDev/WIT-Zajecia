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
MySegment MySegmentNew(MyPoint, MyPoint);
MySegment MySegmentRead(char* myStr1, char* myStr2,
                        char* myStr3, char* myStr4);
void MySegmentPrint(MySegment , char* myStr1, char* myStr2);
MySegment MySegmentMove(MySegment, MySegment);
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
MySegment MySegmentNew(MyPoint p1, MyPoint p2){
    MySegment mySegment;
    mySegment.A=p1;
    mySegment.B=p2;
    return mySegment;
    }
/*******************************************************************/
MySegment MySegmentRead(char* myStr1, char* myStr2,
                        char* myStr3, char* myStr4){
    return MySegmentNew(MyPointRead(myStr1, myStr2),
                        MyPointRead(myStr3, myStr4));
    }
/*******************************************************************/
void MySegmentPrint(MySegment mySegment, char* myStr1, char* myStr2){
    MyPointPrint(mySegment.A, myStr1);
    MyPointPrint(mySegment.B, myStr2);
    }
/*******************************************************************/
MySegment MySegmentMove(MySegment mS1, MySegment mS2){
    return MySegmentNew(MyPointMove(mS1.A, mS2.A),
                        MyPointMove(mS1.B, mS2.B));
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
    MySegmentPrint(MySegmentMove(MySegmentRead("\nA.x ?=",
                                               "\nA.y ?=",
                                               "\nB.x ?=",
                                               "\nB.y ?="),
                                MySegmentRead("\nA.x ?=",
                                               "\nA.y ?=",
                                               "\nB.x ?=",
                                               "\nB.y ?=")
                                 ),"\nA: \n", "\nB:\n");


    return 0;
    }




