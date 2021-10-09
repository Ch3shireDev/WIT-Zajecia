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
    MyList * myHead, *myWalk;

    myHead = (MyList*)malloc(sizeof(MyList));
    myHead->next = (MyList*)malloc(sizeof(MyList));
    myHead->next->next = (MyList*)malloc(sizeof(MyList));
    myHead->next->next->next = (MyList*)malloc(sizeof(MyList));
    myHead->next->next->next->next = (MyList*)malloc(sizeof(MyList));
    myHead->next->next->next->next->next = NULL;

    myHead->x = 0;
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














