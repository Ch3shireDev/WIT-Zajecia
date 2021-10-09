#include <stdio.h>
/***************************************************************************************/
/***************************************************************************************/
struct MyStruct01{
    int x;
    int y;
    };
struct MyStruct02{
    int x;
    int y;
    }typedef MyStruct03;
typedef MyStruct04{
    int x;
    int y;
    }MyStruct05;
typedef{
    int x;
    int y;
    }MyStruct06;
/***************************************************************************************/
/***************************************************************************************/
double MyRead(char* mS){
    double x;
    printf("%s",mS);
    scanf("%lf", &x);
    return x;
    }
/***************************************************************************************/
/***************************************************************************************/
int main(){
    struct MyStruct01 ms1;
    struct MyStruct02 ms2;
    MyStruct03 ms3;
    struct MyStruct04 ms4;
    MyStruct05 ms5;
    MyStruct06 ms6;

    ms1.x = 9;
    ms1.y = 7;

    printf("ms1: x = %d, y = %d\n",ms1.x,ms1.y);

    ms2=ms3;
    /** ms1=ms2 -ERROR*/
    /** printf("\n\n\tms1: %d %d\n\n",ms1,ms1); - bad*/

    return 0;
    }
