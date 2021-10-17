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
    MyList mL00;
    MyList mL01;
    MyList mL02;
    MyList mL03;
    MyList mL04;

    mL00.x = 0;
    mL00.next = (MyList*)malloc(sizeof(MyList));
    mL00.next->x = 1;
    mL00.next->next = &mL02;
    mL00.next->next->x = 2;
    mL00.next->next->next = &mL03;
    mL00.next->next->next->x = 3;
    mL00.next->next->next->next = &mL04;
    mL00.next->next->next->next->x = 4;
    mL00.next->next->next->next->next = NULL;

    printf("mL00.x = %d\n", mL00.x);
    printf("mL01.x = %d\n", mL00.next->x);
    printf("mL02.x = %d\n", mL00.next->next->x);
    printf("mL03.x = %d\n", mL00.next->next->next->x);
    printf("mL04.x = %d\n", mL00.next->next->next->next->x);

    return 0;
    }
