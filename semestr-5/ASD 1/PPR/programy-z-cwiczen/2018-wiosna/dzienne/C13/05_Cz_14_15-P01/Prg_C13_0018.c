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

    mL00 = (MyList*)malloc(sizeof(MyList));
    myWalker = mL00;
    myWalker->next = (MyList*)malloc(sizeof(MyList));
    myWalker = myWalker->next;

    myWalker->next = (MyList*)malloc(sizeof(MyList));
    myWalker = myWalker->next;

    myWalker->next = (MyList*)malloc(sizeof(MyList));
    myWalker->next->next = (MyList*)malloc(sizeof(MyList));
    myWalker->next->next->next = NULL;

    mL00->x = 0;
    mL00->next->x = 1;
    mL00->next->next->x = 2;
    mL00->next->next->next->x = 3;
    mL00->next->next->next->next->x = 4;


    printf("mL00.x = %d\n", mL00->x);
    printf("mL01.x = %d\n", mL00->next->x);
    printf("mL02.x = %d\n", mL00->next->next->x);
    printf("mL03.x = %d\n", mL00->next->next->next->x);
    printf("mL04.x = %d\n", mL00->next->next->next->next->x);

    return 0;
    }
