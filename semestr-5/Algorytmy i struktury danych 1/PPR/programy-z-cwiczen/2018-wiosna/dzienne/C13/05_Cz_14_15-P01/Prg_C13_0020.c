#include <stdio.h>
#include <stdlib.h>
/**************************************************************************************/
typedef struct MyL{
    int x;
    struct MyL* next;
    }MyList;
/**************************************************************************************/
/**************************************************************************************/

/**************************************************************************************/
/**************************************************************************************/


/**************************************************************************************/
/**************************************************************************************/
int main(){
    MyList* mL00;
    MyList* myWalker;
    int i;

    mL00 = (MyList*)malloc(sizeof(MyList));
    myWalker = mL00;

    for(i=1; i<=4;++i){
        myWalker->next = (MyList*)malloc(sizeof(MyList));
        myWalker = myWalker->next;
        }
    myWalker->next = NULL;


    myWalker = mL00;
    for(i=0;i<5;++i){
        myWalker->x = i;
        myWalker = myWalker->next;
        }

    myWalker = mL00;
    for(i=0;i<5;++i){
        printf("mL0%d.x = %d\n",i, myWalker->x);
        myWalker = myWalker->next;
        }

    return 0;
    }
