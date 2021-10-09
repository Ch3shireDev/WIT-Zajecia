#include <stdio.h>
#include <stdlib.h>
/**********************************************************************/
/**********************************************************************/
typedef struct MyL{
    int x;
    struct MyL* next;
    }MyList;
/**********************************************************************/
/**********************************************************************/
void PrintMyList(MyList*, char*);
/**********************************************************************/
/**********************************************************************/
int MyRead(char*);
/*******************************************************************************/
/*******************************************************************************/
void PrintMyList(MyList* myList, char* myStr){
    printf("%s%d\n",myStr, myList->x);
    }
/**********************************************************************/
/**********************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d", &x);
    return x;
    }
/**********************************************************************/
/**********************************************************************/
int main(){
    MyList mL00, mL01, mL02, mL03, mL04;
    MyList * myHead;

    myHead = (MyList*)malloc(sizeof(MyList));
/** mL00.next = &mL01;*/
    myHead->next = (MyList*)malloc(sizeof(MyList));
/** mL01.next = &mL02;*/
    myHead->next->next = (MyList*)malloc(sizeof(MyList));
/** mL02.next = &mL03;*/
    myHead->next->next->next = (MyList*)malloc(sizeof(MyList));
/** mL03.next = &mL04;*/
    myHead->next->next->next->next = (MyList*)malloc(sizeof(MyList));
/** mL04.next = NULL;*/
    myHead->next->next->next->next->next = NULL;

/**    mL00.x = 0;*/
    myHead->x = 0;
/**    mL01.x = 1;*/
    myHead->next->x = 1;
    myHead->next->next->x = 2;
    myHead->next->next->next->x = 3;
    myHead->next->next->next->next->x = 4;

    PrintMyList(myHead,"mL00->x = ");
    PrintMyList(myHead->next,"mL01->x = ");
    PrintMyList(myHead->next->next,"mL02->x = ");
    PrintMyList(myHead->next->next->next,"mL03->x = ");
    PrintMyList(myHead->next->next->next->next,"mL04->x = ");




    return 0;
    }














