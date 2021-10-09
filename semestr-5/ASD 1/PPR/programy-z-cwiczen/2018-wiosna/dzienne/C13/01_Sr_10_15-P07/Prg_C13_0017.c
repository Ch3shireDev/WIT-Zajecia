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
    int i;
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

/**    for(myWalk = myHead, i=0;myWalk;myWalk->x=i++,myWalk=myWalk->next);*/

    myWalk = myHead;
    i=0;
    while(myWalk!=NULL){
        myWalk->x = i++;
        myWalk = myWalk->next;
        }


    myWalk = myHead;
    while(myWalk!=NULL){
        PrintMyList(myWalk,"mL->x = ");
        myWalk = myWalk->next;
        }

    return 0;
    }














