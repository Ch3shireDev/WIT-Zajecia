///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
struct{
    int x;
    int y;
    }typedef Point;
///******************************************************
typedef struct{
    Point X;
    Point Y;
    }Segment;
///******************************************************
///******************************************************
Point PointNew(int, int);
Point PointPrint(Point);
Point PointAdd(Point, Point);
///******************************************************
Segment SegmentNew(Point, Point);
Segment SegmentPrint(Segment );
///******************************************************
///******************************************************
Point PointNew(int x, int y){
    Point pt;
    pt.x = x;
    pt.y = y;
    return pt;
    }
///******************************************************
Point PointPrint(Point p2){
    printf("x = %d, y = %d\n",p2.x, p2.y);
    return p2;
    }
///******************************************************
Point PointAdd(Point p1, Point p2){
    return PointNew(p1.x + p2.x, p1.y + p2.y);
    }
///******************************************************
///******************************************************
Segment SegmentNew(Point X, Point Y){
    Segment sG;
    sG.X = X;
    sG.Y = Y;
    return sG;
    }
///******************************************************
Segment SegmentPrint(Segment sG1){
    printf("X: ");
    PointPrint(sG1.X);
    printf("Y: ");
    PointPrint(sG1.Y);
    return sG1;
    }
///******************************************************
///******************************************************
int main(){
    Segment sG1;
    sG1 = SegmentNew(PointNew(1,2),PointNew(3,4));
    sG1.X.x = 12;

    SegmentPrint(sG1);
    return 0;
    }
///2, 3, 4, 5
