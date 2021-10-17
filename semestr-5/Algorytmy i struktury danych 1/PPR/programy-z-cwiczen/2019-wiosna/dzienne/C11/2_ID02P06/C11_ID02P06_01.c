///213.135.45.65:7080
#include <stdio.h>
#include <stdlib.h>
///*********************************************************
void* MyStruct(double, int);
double* MyStructX(void*);
int* MyStructY(void*);
///*********************************************************
///*********************************************************
void* MyStruct(double x, int y){
    void* myS = malloc(sizeof(double)+sizeof(int));
    double* sX;
    int* sY;
    sX=(double*)myS;
    *sX = x;
    ++sX;
    sY=(int*)sX;
    *sY = y;

    return myS;
    }
///*********************************************************
double* MyStructX(void* mS){
    return (double*)mS;
    }
///*********************************************************
int* MyStructY(void* mS){
    double* sX;
    int* sY;
    sX=(double*)mS;
    ++sX;
    sY = (int*)sX;
    return sY;
    }
///*********************************************************
///*********************************************************
int main(){
    void* myS = MyStruct(2.7, 9);
    printf("x = %f, y = %d\n", *MyStructX(myS), *MyStructY(myS));

    return 0;
    }
