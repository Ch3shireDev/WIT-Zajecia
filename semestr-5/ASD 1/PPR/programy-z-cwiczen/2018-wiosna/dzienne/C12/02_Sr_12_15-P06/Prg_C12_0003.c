#include <stdio.h>
/***************************************************************************************/
/***************************************************************************************/
typedef struct {
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
MyPoint MyPointNew(double, double);
void MyPointPrint(MyPoint, char*);
MyPoint MyPointMove(MyPoint, MyPoint);
/***************************************************************************************/
/***************************************************************************************/
MySegment MySegmentNew(MyPoint, MyPoint);
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
void MyPointPrint(MyPoint myPoint, char* mS){
    printf("%sx = %f, y = %f",mS, myPoint.x, myPoint.y);
    }
/***************************************************************************************/
MyPoint MyPointMove(MyPoint myPoint, MyPoint myMove){
    return MyPointNew(myPoint.x + myMove.x, myPoint.y + myMove.y);
    }
/***************************************************************************************/
/***************************************************************************************/
MySegment MySegmentNew(MyPoint A, MyPoint B){
    MySegment mySegment;
    mySegment.A = A;
    mySegment.B = B;
    return mySegment;
    }
/***************************************************************************************/
void MySegmentPrint(MySegment mySegment, char* mSA, char* mSB){
    MyPointPrint(mySegment.A, mSA);
    MyPointPrint(mySegment.B, mSB);
    }
/***************************************************************************************/
MySegment MySegmentMove(MySegment mySegment, MyPoint myMove){
    return MySegmentNew(MyPointMove(mySegment.A, myMove),
                        MyPointMove(mySegment.B, myMove));
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
    MyPoint mP1, mP2;
    mP1 = MyPointNew(MyRead("\tx ?="),MyRead("\nmP1:\n\ty ?="));
    MyPointPrint(mP1, "\nmP1:\t");
    mP2=MyPointMove(mP1, MyPointNew(1,2));
    MyPointPrint(mP2, "\nmP2:\t");


    return 0;
    }
