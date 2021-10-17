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
Segment SegmentNew(Point, Point);
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
Segment SegmentNew(Point X, Point Y){
    Segment sG1;
    sG1.X = X;
    sG1.Y = Y;
    return sG1;
    }
///*********************************************************
///*********************************************************
int main(){
    Segment s1;
    int* pt;
    s1 = SegmentNew(PointNew(1,2), PointNew(3,4));


    printf("X: x = %d, y = %d, Y: x = %d, y = %d\n", s1.X.x, s1.X.y, s1.Y.x, s1.Y.y);


    pt= (int*)&s1;

    for(int i= 0; i<4;++i){
        printf("%d\n",*pt);
        ++pt;
        }

    return 0;
    }
///1, 2, 3
