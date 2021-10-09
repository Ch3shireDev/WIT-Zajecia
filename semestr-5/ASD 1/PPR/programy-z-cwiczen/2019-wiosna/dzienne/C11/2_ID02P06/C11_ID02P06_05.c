///213.135.45.65:7080
#include <stdio.h>
#include <stdlib.h>
///*********************************************************
typedef struct {
    int x;
    int y;
    }Point;
///*********************************************************
Point PointNew(int, int);
Point PointPrint(Point);
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
///*********************************************************
int main(){
    Point myP1;

    myP1 = PointNew(12, 7);

    PointPrint(PointPrint(PointPrint(myP1)));

    return 0;
    }

