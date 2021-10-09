#include<stdio.h>
#include<stdlib.h>
/*********************************************************************************************/
typedef struct{
    double x;
    double y;
    }MyPoint;
/*********************************************************************************************/
typedef struct{
    MyPoint A;
    MyPoint B;
    }MySegment;
/*********************************************************************************************/
/*********************************************************************************************/
MyPoint MyPointNew(double, double);
MyPoint MyPointRead(char*, char*);
void MyPointPrint(MyPoint, char*);
MyPoint MyPointMove(MyPoint, MyPoint);
/*********************************************************************************************/
/*********************************************************************************************/
MySegment MySegmentNew(MyPoint, MyPoint);
MySegment MySegmentRead(char*, char*, char*, char*);
void MySegmentPrint(MySegment, char*, char*);
MySegment MySegmentMove(MySegment, MySegment);
/*********************************************************************************************/
double MyRead(char*);
/*********************************************************************************************/
/*********************************************************************************************/
MyPoint MyPointNew(double x, double y){
    MyPoint myPoint;

    myPoint.x = x;
    myPoint.y = y;

    return myPoint;
    }
/*********************************************************************************************/
MyPoint MyPointRead(char* myStr1, char* myStr2){
    return MyPointNew(MyRead(myStr1), MyRead(myStr2));
    }
/*********************************************************************************************/
void MyPointPrint(MyPoint myPoint, char* myStr){
    printf("%sx = %f, y = %f\n", myStr, myPoint.x, myPoint.y);
    }
/*********************************************************************************************/
MyPoint MyPointMove(MyPoint sourcePoint, MyPoint movePoint){
    return MyPointNew(sourcePoint.x + movePoint.x,
                      sourcePoint.y + movePoint.y);
    }
/*********************************************************************************************/
/*********************************************************************************************/
MySegment MySegmentNew(MyPoint A, MyPoint B){
    MySegment mySegment;
    mySegment.A = A;
    mySegment.B = B;

    return mySegment;
    }
/*********************************************************************************************/
MySegment MySegmentRead(char* mS1, char* mS2, char* mS3, char* mS4){
    return MySegmentNew(MyPointRead(mS1, mS2), MyPointRead(mS3, mS4));
    }
/*********************************************************************************************/
void MySegmentPrint(MySegment mySegment, char* mS1, char* mS2){
    MyPointPrint(mySegment.A,mS1);
    MyPointPrint(mySegment.B,mS2);
    }
/*********************************************************************************************/
MySegment MySegmentMove(MySegment mSs, MySegment mSm){
    return MySegmentNew(MyPointMove(mSs.A,mSm.A), MyPointMove(mSs.B, mSm.B));
    }
/*********************************************************************************************/
/*********************************************************************************************/
double MyRead(char* myStr){
    double x;
    printf("%s", myStr);
    scanf("%lf", &x);

    return x;
    }
/*********************************************************************************************/
/*********************************************************************************************/
int main(){
    MySegment mS = MySegmentRead("\tx ?=","A:\n\ty ?=","\tx ?=","mS: B:\n\ty ?=");
    MySegment mM;
    MySegmentPrint(mS,"\n************\nmS:\n\t A:","\n\t B:");
    mM = MySegmentMove(mS, MySegmentNew(MyPointNew(1,1), MyPointNew(2,2)));
    MySegmentPrint(mM,"\n************\nmM:\n\t A:","\n\t B:");

    return 0;
    }
