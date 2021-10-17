#include <iostream>
#include <cstdio>
#include <cstdlib>

using namespace std;
///************************************************************************************
///************************************************************************************
struct MyPoint{
    double x;
    double y;
    };
///************************************************************************************
struct MySegment{
    MyPoint A;
    MyPoint B;
    };
///************************************************************************************
///************************************************************************************
MyPoint MyPointNew(double, double);
void MyPointPrint(MyPoint, string);
MyPoint MyPointMove(MyPoint , MyPoint);
///************************************************************************************
///************************************************************************************
MySegment MySegmentNew(MyPoint, MyPoint);
void MySegmentPrint(MySegment, string, string);
MySegment MySegmentMove(MySegment , MyPoint);
///************************************************************************************
///************************************************************************************
double MyRead(string);
///************************************************************************************
///************************************************************************************
MyPoint MyPointNew(double x, double y){
    MyPoint myPoint;

    myPoint.x = x;
    myPoint.y = y;

    return myPoint;
    }
///************************************************************************************
void MyPointPrint(MyPoint myPoint, string mS){
    cout<<mS;
    cout<<"x = "<<myPoint.x<<", y = "<<myPoint.y;
    }
///************************************************************************************
MyPoint MyPointMove(MyPoint mP1, MyPoint mP2){
    return MyPointNew(mP1.x + mP2.x, mP1.y + mP2.y);
    }
///************************************************************************************
///************************************************************************************
MySegment MySegmentNew(MyPoint mP1, MyPoint mP2){
    MySegment mySegment;
    mySegment.A = mP1;
    mySegment.B = mP2;
    return mySegment;
    }
///************************************************************************************
void MySegmentPrint(MySegment mySegment, string mS1, string mS2){
    MyPointPrint(mySegment.A,mS1);
    MyPointPrint(mySegment.B,mS2);
    }
///************************************************************************************
MySegment MySegmentMove(MySegment mySegment, MyPoint myPoint){
    return MySegmentNew(MyPointMove(mySegment.A, myPoint),
                        MyPointMove(mySegment.B, myPoint));
    }
///************************************************************************************
///************************************************************************************
double MyRead(string mS){
    double x;
    cout<<mS;
    cin>>x;
    return x;
    }
///************************************************************************************
///************************************************************************************

int main(){
    MyPoint A, B, mPV;
    A = MyPointNew(MyRead("\tx ?="), MyRead("\nA:\n\ty ?="));
    B = MyPointNew(MyRead("\tx ?="), MyRead("\nB:\n\ty ?="));
    mPV = MyPointNew(MyRead("\tx ?="), MyRead("\nmPV:\n\ty ?="));

    MySegment mySegment = MySegmentNew(A, B);
    MySegment msMoved;
    MySegmentPrint(mySegment,"\nmySegment:\n\tA: ", "\n\tB: ");
    msMoved = MySegmentMove(mySegment, mPV);
    MySegmentPrint(msMoved,"\n\n****************************\nmsMoved:\n\tA: ", "\n\tB: ");

    return 0;
    }











