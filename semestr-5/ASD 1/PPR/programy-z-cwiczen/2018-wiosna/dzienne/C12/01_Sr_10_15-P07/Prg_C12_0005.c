#include <stdio.h>
/***************************************************************************************/
/***************************************************************************************/
typedef struct{
    double x;
    double y;
    }MyPoint;
/***************************************************************************************/
/***************************************************************************************/
typedef struct{
    MyPoint A;
    MyPoint B;
    }MySegment;
/***************************************************************************************/
/***************************************************************************************/
MyPoint MyPointNew(double,double);
void MyPointPrint(MyPoint, char*);
MyPoint MyPointMove(MyPoint, MyPoint);
/***************************************************************************************/
/***************************************************************************************/
MySegment MySegmentNew(MyPoint,MyPoint);
void MySegmentPrint(MySegment, char*, char*);
MySegment MySegmentMove(MySegment, MyPoint);
/***************************************************************************************/
/***************************************************************************************/
double MyRead(char*);
/***************************************************************************************/
/***************************************************************************************/
MyPoint MyPointNew(double x, double y){
    MyPoint myPoint;
    myPoint.x = x;
    myPoint.y = y;
    return myPoint;
    }
/***************************************************************************************/
void MyPointPrint(MyPoint myPoint, char * mS){
    printf("%sx = %f, y=%f",mS, myPoint.x, myPoint.y);

    }
/***************************************************************************************/
MyPoint MyPointMove(MyPoint mP1, MyPoint mV){
    return MyPointNew(mP1.x + mV.x, mP1.y + mV.y);
    }
/***************************************************************************************/
MySegment MySegmentNew(MyPoint A,MyPoint B){
    MySegment mySegment;
    mySegment.A=A;
    mySegment.B=B;
    return mySegment;
    }
/***************************************************************************************/
void MySegmentPrint(MySegment mySegment, char* mS1, char* mS2){
    MyPointPrint(mySegment.A,mS1);
    MyPointPrint(mySegment.B,mS2);
    }
/***************************************************************************************/
MySegment MySegmentMove(MySegment mySegment, MyPoint myPoint){
    return MySegmentNew(MyPointMove(mySegment.A, myPoint),
                        MyPointMove(mySegment.B, myPoint));
    }
/***************************************************************************************/
/***************************************************************************************/
double MyRead(char* mS){
    double x;
    printf("%s",mS);
    scanf("%lf", &x);
    return x;
    }
/***************************************************************************************/
/***************************************************************************************/
int main(){
    MySegment mS1, mS2;;
    mS1 = MySegmentNew(MyPointNew(1,5),MyPointNew(2,7));
    MySegmentPrint(mS1, "\nmS1:\n\tA: ", "\n\tB: ");
    mS2 = MySegmentMove(mS1,MyPointNew(1,2));
    MySegmentPrint(mS2, "\nmS2:\n\tA: ", "\n\tB: ");


    return 0;
    }
