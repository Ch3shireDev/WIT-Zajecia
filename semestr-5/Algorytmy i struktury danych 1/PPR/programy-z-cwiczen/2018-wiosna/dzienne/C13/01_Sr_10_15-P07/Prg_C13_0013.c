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
    myWalk = myHead;
    myWalk->next = (MyList*)malloc(sizeof(MyList));
    myWalk = myWalk->next;
    myWalk->next = (MyList*)malloc(sizeof(MyList));
    myWalk->next->next = (MyList*)malloc(sizeof(MyList));
    myWalk->next->next->next = (MyList*)malloc(sizeof(MyList));
    myWalk->next->next->next->next = NULL;

    myWalk = myHead;
    myWalk->x = 0;
    myWalk = myWalk->next;
    myWalk->x = 1;
    myWalk->next->x = 2;
    myWalk->next->next->x = 3;
    myWalk->next->next->next->x = 4;

    myWalk = myHead;
    PrintMyList(myWalk,"mL->x = ");
    myWalk = myWalk->next;
    PrintMyList(myWalk,"mL->x = ");
    PrintMyList(myWalk->next,"mL->x = ");
    PrintMyList(myWalk->next->next,"mL->x = ");
    PrintMyList(myWalk->next->next->next,"mL->x = ");




    return 0;
    }














