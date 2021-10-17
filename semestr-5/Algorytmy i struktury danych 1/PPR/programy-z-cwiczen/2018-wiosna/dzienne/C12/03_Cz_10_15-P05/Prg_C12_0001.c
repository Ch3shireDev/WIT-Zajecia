#include<stdio.h>
#include<stdlib.h>

typedef int aqq;
/*******************************************************************/
struct MyStruct0{
    int x1;
    aqq x2;
    };
/*******************************************************************/
struct MyStruct1{
    int x1;
    aqq x2;
    }typedef MyStruct2;
/*******************************************************************/
struct{
    int x1;
    aqq x2;
    }typedef MyStruct3;
/*******************************************************************/
/*******************************************************************/

/*******************************************************************/
/*******************************************************************/
int main(){
    struct MyStruct0 myStruct0;
    struct MyStruct1 myStruct1;
    MyStruct2 myStruct2;
    MyStruct3 myStruct3;

    aqq x1;
    int x2;
    x2=x1;

    /** myStruct0 = myStruct1;*/
    myStruct1 = myStruct2;

    return 0;
    }
