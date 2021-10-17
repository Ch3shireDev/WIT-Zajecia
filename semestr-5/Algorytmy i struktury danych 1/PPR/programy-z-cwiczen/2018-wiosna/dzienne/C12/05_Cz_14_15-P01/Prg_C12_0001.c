#include<stdio.h>
#include<stdlib.h>
typedef int aqq;
/*******************************************************************/
/*******************************************************************/
struct MyStruct0{
    int x;
    aqq y;
    };
/*******************************************************************/
struct MyStruct1{
    int x;
    aqq y;
    }typedef MyStruct2;
/*******************************************************************/
typedef struct MyStruct3{
    int x;
    aqq y;
    };
/*******************************************************************/
typedef struct MyStruct4{
    int x;
    aqq y;
    }MyStruct5;
/*******************************************************************/
typedef struct{
    int x;
    aqq y;
    }MyStruct6;
/*******************************************************************/
/*******************************************************************/
int MyRead(char*);
/*******************************************************************/
/*******************************************************************/

/*******************************************************************/
/*******************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
/*******************************************************************/
/*******************************************************************/
int main(){
    struct MyStruct0 myStruct0;
    struct MyStruct1 myStruct1;
    MyStruct2 myStruct2;
    struct MyStruct3 myStruct3;
    struct MyStruct4 myStruct4;
    MyStruct5 myStruct5;
    MyStruct6 myStruct6;
    int y;
    aqq z = 12;
    myStruct0.x = 12;
    y = myStruct0.x;
    y = z;
    myStruct1 = myStruct2;
    /** myStruct1 = myStruct0; error */


    return 0;
    }
