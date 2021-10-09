///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
struct {
    double x;
    int y;

    }typedef Str01;

///******************************************************
void* MyStruct(double x, int y);
double* MyStructX(void*);
int* MyStructY(void*);
///******************************************************
void* MyStruct(double x, int y){
    void * myStr;
    double *mx;
    int* my;
    myStr = malloc(sizeof(double) + sizeof(int));
    mx = (double*)myStr;
    *mx= x;
    ++mx;
    my=(int*)mx;
    *my = y;

    return myStr;
    }
///******************************************************
double* MyStructX(void* myStr){
    return (double*)myStr;
    }
///******************************************************
int* MyStructY(void* myStr){
    double* mS = (double*) myStr;
    ++mS;
    return (int*)mS;
    }
///******************************************************
///******************************************************
int main(){
    Str01 mS00;
    void* mS = MyStruct(2.5,4);

    printf("x = %f, y = %d\n", *MyStructX(mS),*MyStructY(mS));

    mS00.x = 2.5;
    mS00.y = 4;

    printf("x = %f, y = %d\n", mS00.x, mS00.y);

    return 0;
    }
