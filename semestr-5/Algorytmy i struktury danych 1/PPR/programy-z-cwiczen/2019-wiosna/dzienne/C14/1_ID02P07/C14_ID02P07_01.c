///213.135.45.65:7070
#include <stdio.h>
#include <stdlib.h>
typedef  struct MyL{
    int x1;
    int x0;
    struct MyL* next;

    }MyList;
///*************************************************
MyList* MyListNew(int, int);
MyList* MyListPrintNode(MyList*);
///*************************************************
MyList* MyListNew(int x1, int x0){
    MyList * myList;

    myList = (MyList*)malloc(sizeof(MyList));
    myList->x1 = x1;
    myList->x0 = x0;
    myList->next = NULL;

    return myList;
    }
///*************************************************
MyList* MyListPrintNode(MyList* myList){
    if(NULL != myList) printf("%d %d ",myList->x1, myList->x0);
    return myList;
    }
///*************************************************
///*************************************************



///*************************************************
///*************************************************
int main(){
    MyList * myL0;
    myL0 = MyListNew(1,2);
    myL0->next = MyListNew(3,4);
    MyListPrintNode(MyListPrintNode(myL0)->next);
    printf("\n");
    MyListPrintNode(myL0);
    MyListPrintNode(myL0->next);
    printf("\n");
    return 0;
    }
