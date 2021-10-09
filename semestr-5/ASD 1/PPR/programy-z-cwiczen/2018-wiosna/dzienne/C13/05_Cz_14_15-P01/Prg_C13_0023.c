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

    for(mL00 = (MyList*)malloc(sizeof(MyList)),myWalker = mL00,i=4; i;--i,
        myWalker->next = (MyList*)malloc(sizeof(MyList)),myWalker = myWalker->next,
        myWalker->next = NULL);


    for(i=0,myWalker=mL00;myWalker;++i,myWalker->x=i,myWalker=myWalker->next);

    for(myWalker=mL00,i=0;
        myWalker;printf("mL0%d.x = %d\n",i, myWalker->x),
        ++i,myWalker = myWalker->next);

    return 0;
    }
