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
MyList* NewMyList(int);
MyList* FillMyList(MyList*, int, int);
void PrintMyList(MyList*, char*);
MyList* PrintAllList(MyList*);
/**********************************************************************/
/**********************************************************************/
int MyRead(char*);
/*******************************************************************************/
/**********************************************************************/
MyList* NewMyList(int n){
    MyList * myHead, *myWalk;
    int i;

    myHead = (MyList*)malloc(sizeof(MyList));
    myWalk = myHead;
    for(i=1;i<n;++i){
        myWalk->next = (MyList*)malloc(sizeof(MyList));
        myWalk = myWalk->next;
        }
    myWalk->next = NULL;
    return myHead;
    }
/*******************************************************************************/
MyList* FillMyList(MyList* myHead, int a1, int r){
    if(myHead==NULL)return NULL;
    myHead->x = a1;
    while(myHead->next){
        myHead->next->x = myHead->x+r;
        myHead = myHead->next;
        }
    return myHead;
    }
/*******************************************************************************/
void PrintMyList(MyList* myList, char* myStr){
    printf("%s%d\n",myStr, myList->x);
    }
/**********************************************************************/
MyList* PrintAllList(MyList* myHead){
    if(myHead==NULL) return NULL;
    PrintMyList(myHead, "x = ");
    while(myHead->next){
        PrintMyList(myHead->next, "x = ");
        myHead = myHead->next;
        }
    return myHead;
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
    myHead = NewMyList(12);


/**    for(myWalk = myHead, i=0;myWalk;myWalk->x=i++,myWalk=myWalk->next);*/
    FillMyList(myHead, 2, 2);


    myWalk = myHead;
    while(myWalk){
        PrintMyList(myWalk,"mL->x = ");
        myWalk = myWalk->next;
        }

    return 0;
    }














