#include<stdio.h>
#include<stdlib.h>
/*********************************************************************************************/
typedef struct{
    double x;
    double y;
    }MyPoint;
/*********************************************************************************************/
/*********************************************************************************************/
MyPoint MyPointNew(double, double);
MyPoint MyPointRead(char*, char*);
void MyPointPrint(MyPoint, char*);
MyPoint MyPointMove(MyPoint, MyPoint);
/*********************************************************************************************/
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
double MyRead(char* myStr){
    double x;
    printf("%s", myStr);
    scanf("%lf", &x);

    return x;
    }
/*********************************************************************************************/
/*********************************************************************************************/
int main(){
    MyPoint myPoint0;
    MyPoint myPoint1;

    myPoint0 = MyPointRead("\tx ?=", "\nmyPoint0:\n\ty ?=");
    MyPointPrint(myPoint0, "\n***********************\nmyPoint0:\n\t");

    myPoint1 = MyPointMove(myPoint0, MyPointNew(1,2));
    MyPointPrint(myPoint1, "\n***********************\nmyPoint1:\n\t");

    return 0;
    }
