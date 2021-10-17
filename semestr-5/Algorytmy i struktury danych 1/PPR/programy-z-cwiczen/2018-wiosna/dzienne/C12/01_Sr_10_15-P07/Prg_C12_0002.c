#include <stdio.h>
typedef int aqq;
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
typedef struct MyStruct04{
    int x;
    int y;
    }MyStruct05, MyStruct06;

typedef struct{
    int x;
    int y;
    }MyStruct07;

/***************************************************************************************/
/***************************************************************************************/

/***************************************************************************************/
/***************************************************************************************/
int main(){
    int x;
    aqq y;
    x=7;
    y=x;
    struct MyStruct01 myS01;
    struct MyStruct02 myS02;
    MyStruct03 myS03;
    MyStruct05 myS05;
    MyStruct06 myS06;
    MyStruct07 myS07;

    myS05 = myS06;

    myS01.x = 7;
    myS01.y = 2;

    printf("mS01.x = %d\n",myS01.x);
    printf("mS01.y = %d\n",myS01.y);

    myS02.x = 17;
    myS02.y = 12;

    printf("mS02.x = %d\n",myS02.x);
    printf("mS02.y = %d\n",myS02.y);

    myS03.x = 37;
    myS03.y = 32;

    printf("mS03.x = %d\n",myS03.x);
    printf("mS03.y = %d\n",myS03.y);

    myS03 = myS02;
    printf("mS03.x = %d\n",myS03.x);
    printf("mS03.y = %d\n",myS03.y);

    /**myS01 = myS02; - ERROR*/


    return 0;
    }
