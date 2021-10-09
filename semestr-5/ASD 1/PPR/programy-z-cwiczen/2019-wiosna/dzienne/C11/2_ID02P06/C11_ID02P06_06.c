///213.135.45.65:7080
#include <stdio.h>
#include <stdlib.h>
///*********************************************************
typedef struct {
    int x;
    int y;
    }Point;
///*********************************************************
typedef struct{
    Point X;
    Point Y;
    }Segment;
///*********************************************************
Point PointNew(int, int);
Point PointPrint(Point);
Point PointAdd(Point, Point);
///*********************************************************
///*********************************************************
Point PointNew(int x, int y){
    Point myP1;
    myP1.x = x;
    myP1.y = y;
    return myP1;
    }
///*********************************************************
Point PointPrint(Point myP1){
    printf("x = %d, y = %d\n", myP1.x, myP1.y);
    return myP1;
    }
///*********************************************************
Point PointAdd(Point p1, Point p2){
    return PointNew(p1.x + p2.x, p1.y + p2.y);
    }
///*********************************************************
///*********************************************************
int main(){
    Point p1, p2, p3;

    p1 = PointNew(12, 7);
    p2 = PointNew(-7, 2);

    p3 = PointAdd(p1, p2);

    PointPrint(p3);

    ///x = 5, y = 9

    return 0;
    }
///3, 4, 5
