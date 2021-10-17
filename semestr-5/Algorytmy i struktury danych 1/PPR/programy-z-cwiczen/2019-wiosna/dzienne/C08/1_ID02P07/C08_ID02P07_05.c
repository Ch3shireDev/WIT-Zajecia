#include <stdio.h>
///213.135.45.65:7070
///************************************************************
typedef int (*MyFF)(int, int);
///************************************************************
int MyRead(char*);
int MyMax(int,int);
int MyMin(int,int);
int MySum(int,int);
int MyTest(MyFF, int, int);
int MyTest2(MyFF, MyFF, int, int);
///************************************************************
///************************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///************************************************************
int MyMax(int x, int y){
    if(x>y) return x;
    return y;
    }
///************************************************************
int MyMin(int x, int y){
    if(x<y) return x;
    return y;
    }
///************************************************************
int MySum(int x,int y){
    return x+y;
    }
///************************************************************
int MyTest(MyFF myF, int x, int y){
    return myF(x,y);
    }
///************************************************************
int MyTest2(MyFF myF1, MyFF myF2, int x, int y){
    return myF1(x,y) + myF2(x,y);
    }
///************************************************************
///************************************************************
int main(){
    int x, y;
    MyFF* myT;
    int sT =5;
    x = MyRead("x? = ");
    y = MyRead("y? = ");

    myT= (MyFF*)malloc(sizeof(MyFF)*sT);

    myT[0] = MyMax;
    myT[1] = MyMin;
    myT[2] = MyMin;
    myT[3] = MySum;
    myT[4] = MyMax;

    for(int i =0; i<sT;++i)
        printf("%d\n", myT[i](x,y));

    printf("Max(%d, %d) = %d\n", x, y, MyTest(MyMax,x,y));
    printf("Min(%d, %d) = %d\n", x, y, MyTest(MyMin,x,y));
    printf("%d + %d = %d\n", x, y, MyTest(MySum,x,y));
    printf("max + max = %d\n",MyTest2(MyMax, MyMax, x, y) );

    return 0;
    }
///3, 4, 5
/**

max + max - MyTest2(...., x, y) -- printf("max + max = %d\n",MyTest2(...., x, y) );
x? = 3
y? = 4
max + max = 8
--------------------------------------------------------------------------------
max + min - MyTest2(...., x, y) -- printf("max + min = %d\n",MyTest2(...., x, y) );
max + min = 7
--------------------------------------------------------------------------------

min + min - MyTest2(...., x, y)
sum + sum - MyTest2(...., x, y)
sum + max - MyTest2(...., x, y)
sum + min - MyTest2(...., x, y)

*/
