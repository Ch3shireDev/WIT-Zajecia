///213.135.45.65:7070
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
typedef  struct MyL{
    int x1;
    int x0;
    struct MyL* next;

    }MyList;
///*************************************************
MyList* MyListNew(int, int);
MyList* MyListPrintNode(MyList*);
MyList* MyListRand(int length, int a, int b);
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
MyList* MyListRand(int length, int a, int b){
    MyList * myList,* myWalk;
    myList = MyListNew(rand()%(b-a)+a,rand()%(b-a)+a);
    myWalk = myList;
    for(int i = 1; i<length;++i){
        myWalk->next = MyListNew(rand()%(b-a)+a,rand()%(b-a)+a);
        myWalk = myWalk->next;
        }
    return myList;
    }
///*************************************************
///*************************************************



///*************************************************
///*************************************************
int main(){
    srand(time(0));
    MyList * myL0, *myWalk;
    myL0 = MyListNew(1,2);
    myWalk = myL0;

    myWalk->next = MyListNew(3,4);
    myWalk = myWalk->next;

    myWalk->next = MyListNew(rand()%100,rand()%100);
    myWalk = myWalk->next;

    myWalk->next = MyListNew(rand()%100,rand()%100);
    myWalk = myWalk->next;

    myWalk->next = MyListNew(rand()%100,rand()%100);



    return 0;
    }
