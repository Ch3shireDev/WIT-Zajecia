///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
struct{
    int x;
    int y;
    }typedef Point;
///******************************************************
Point PointNew(int, int);
Point PointPrint(Point);
Point PointAdd(Point, Point);
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
int main(){
    Point p1, p2, p3;
    p1 = PointNew(3, 6);
    p2 = PointNew(4,-2);

    printf("x = %d, y = %d\n",p1.x, p1.y);
    PointPrint(p1);
    printf("********************\n\n");
    PointPrint(PointPrint(p1));

    p3 = PointAdd(p1, p2);
    PointPrint(p3);
    return 0;
    }
///2, 3, 4, 5
