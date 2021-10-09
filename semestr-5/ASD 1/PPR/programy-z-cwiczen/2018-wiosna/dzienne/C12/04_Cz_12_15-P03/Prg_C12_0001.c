#include<stdio.h>
#include<stdlib.h>
typedef int aqq;
/*******************************************************************/
struct MyStruct0{
    int x;
    int y;
    aqq z;
    };
/*******************************************************************/
struct MyStruct1{
    int x;
    int y;
    aqq z;
    }typedef MyStruct2;
/*******************************************************************/
struct{
    int x;
    int y;
    aqq z;
    }typedef MyStruct3;
/*******************************************************************/
typedef struct MyStruct4{
    int x;
    int y;
    aqq z;
    };
/*******************************************************************/
typedef struct {
    int x;
    int y;
    aqq z;
    }MyStruct5;
/*******************************************************************/
/*******************************************************************/
int main(){
    struct MyStruct0 myStruct0;
    struct MyStruct1 myStruct1;
    MyStruct2 myStruct2;
    MyStruct3 myStruct3;
    struct MyStruct4 myStruct4;
    MyStruct5 myStruct5;
    int x=9;
    aqq y=x;
    printf("y = %d\n",y);

    myStruct1 = myStruct2;
    /** myStruct0 = myStruct2; error: myStruct0 and myStuct2 are different types*/

    myStruct0.x = 1;
    myStruct0.y = 2;
    myStruct0.z = 3;

    myStruct1.x = 1;
    myStruct1.y = 2;
    myStruct1.z = 3;

    myStruct2.x = 1;
    myStruct2.y = 2;
    myStruct2.z = 3;

    myStruct3.x = 1;
    myStruct3.y = 2;
    myStruct3.z = 3;

    myStruct4.x = 1;
    myStruct4.y = 2;
    myStruct4.z = 3;

    myStruct5.x = 1;
    myStruct5.y = 2;
    myStruct5.z = 3;

    y = myStruct0.x;

    return 0;
    }
