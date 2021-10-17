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
    myWalk = myWalk->next;
    myWalk->next = (MyList*)malloc(sizeof(MyList));
    myWalk = myWalk->next;
    myWalk->next = (MyList*)malloc(sizeof(MyList));
    myWalk = myWalk->next;
    myWalk->next = NULL;

    myWalk = myHead;
    myWalk->x = 0;
    myWalk = myWalk->next;
    myWalk->x = 1;
    myWalk = myWalk->next;
    myWalk->x = 2;
    myWalk = myWalk->next;
    myWalk->x = 3;
    myWalk = myWalk->next;
    myWalk->x = 4;

    myWalk = myHead;
    PrintMyList(myWalk,"mL->x = ");
    myWalk = myWalk->next;
    PrintMyList(myWalk,"mL->x = ");
    myWalk = myWalk->next;
    PrintMyList(myWalk,"mL->x = ");
    myWalk = myWalk->next;
    PrintMyList(myWalk,"mL->x = ");
    myWalk = myWalk->next;
    PrintMyList(myWalk,"mL->x = ");




    return 0;
    }














