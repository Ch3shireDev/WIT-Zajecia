#include<stdio.h>
#include<stdlib.h>
/*******************************************************************/
typedef struct {
    int x;
    int y;
    }MyPoint;
/*******************************************************************/
typedef struct{
    MyPoint A;
    MyPoint B;
    }MySegment;
/*******************************************************************/
MyPoint MyPointNew(int, int);
MyPoint MyPointRead(char*, char*);
void MyPointPrint(MyPoint, char*);
MyPoint MyPointMove(MyPoint, MyPoint);
/*******************************************************************/
MySegment MySegmentNew(MyPoint, MyPoint);
MySegment MySegmentRead(char*, char*, char*, char*);
void MySegmentPrint(MySegment, char*, char*);
MySegment MySegmentMove(MySegment, MySegment);
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
    return MyPointNew(MyRead(myStr1),MyRead(myStr2));
    }
/*******************************************************************/
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %d, y=%d",myStr, myPoint.x, myPoint.y);
    }
/*******************************************************************/
MyPoint MyPointMove(MyPoint p1, MyPoint p2){
    return MyPointNew(p1.x + p2.x, p1.y+p2.y);
    }
/*******************************************************************/
/*******************************************************************/
MySegment MySegmentNew(MyPoint p1, MyPoint p2){
    MySegment mySegment;
    mySegment.A = p1;
    mySegment.B = p2;
    return mySegment;
    }
/*******************************************************************/
MySegment MySegmentRead(char* mS1, char* mS2, char* mS3, char* mS4){
    return MySegmentNew(MyPointRead(mS1, mS2), MyPointRead(mS3, mS4));
    }
/*******************************************************************/
void MySegmentPrint(MySegment mySegment, char* myStr1, char* myStr2){
    MyPointPrint(mySegment.A,myStr1);
    MyPointPrint(mySegment.B,myStr2);
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
    MySegment mS;
    mS= MySegmentRead("A.x ?=",
                      "A.y ?=",
                      "B.x ?=",
                      "\n***********\nB.y ?=");
    MySegmentPrint(mS, "\nA:\n","\nB:\n" );

    MySegmentPrint(MySegmentMove(mS, MySegmentNew(
                                        MyPointNew(1,1),
                                        MyPointNew(2,2)))
                   , "\nA:\n","\nB:\n" );

    return 0;
    }
