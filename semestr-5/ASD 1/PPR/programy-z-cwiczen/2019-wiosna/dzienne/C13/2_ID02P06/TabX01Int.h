#ifndef TabX01Int_H
#define TabX01Int_H
///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int* pT;
    int sT;
    }TabX01Int;
///********************************************************
///********************************************************
TabX01Int TabX01IntNew(int);
TabX01Int TabX01IntDelete(TabX01Int*);
TabX01Int TabX01IntRand(TabX01Int, int, int);
TabX01Int TabX01IntPrint(TabX01Int, int);
TabX01Int TabX01IntLoad(char*);
TabX01Int TabX01IntSave(TabX01Int, char*);
TabX01Int TabX01IntCopy(TabX01Int);
///********************************************************
///********************************************************
int MyRead(char*);
///********************************************************
///********************************************************

#include"TabX01Int.c"
#endif//TabX01Int_H