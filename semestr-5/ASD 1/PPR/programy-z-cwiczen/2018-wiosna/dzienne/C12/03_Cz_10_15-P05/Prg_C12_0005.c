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
MyPoint MyPointAdd(MyPoint, MyPoint);
MySegment MySegmentNew(MyPoint, MyPoint);
MySegment MySegmentAdd(MySegment, MySegment);
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
MyPoint MyPointAdd(MyPoint p1, MyPoint p2){
    return MyPacking(p1.x+p2.x, p1.y+p2.y);
    }
/*******************************************************************/
MySegment MySegmentNew(MyPoint p1, MyPoint p2){
    MySegment mS;
    mS.a=p1;
    mS.b=p2;
    return mS;
    }
/*******************************************************************/
MySegment MySegmentAdd(MySegment mS1, MySegment mS2){
    return MySegmentNew(MyPointAdd(mS1.a, mS2.a),
                        MyPointAdd(mS1.b, mS2.b));
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    MySegment mS1, mS2, mS;
    mS1 = MySegmentRead("\n\t> Segment 1:");
    mS2 = MySegmentRead("\n\t> Segment 2:");
    mS = MySegmentAdd(mS1, mS2);
    MySegmentPrint(mS,"mS:");
    return 0;
    }
