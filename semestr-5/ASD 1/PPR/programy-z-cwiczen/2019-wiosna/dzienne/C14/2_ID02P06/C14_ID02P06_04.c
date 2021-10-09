///213.135.45.65:7070
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
///*******************************************************************
typedef struct MyL{///(MyList*)malloc(sizeof(int) *2 + sizeof(void*));
    int x1;
    int x0;
    struct MyL* next;
    }MyList;
///*******************************************************************
MyList* MyListNew(int, int);
MyList* MyListPrintNode(MyList*);
MyList* MyListRand(int length, int a, int b);
///*******************************************************************
///*******************************************************************
int MyRand(int, int);
int MyRead(char*);
///*******************************************************************
///*******************************************************************
MyList* MyListNew(int x1, int x0){
    MyList* myList;
    myList = (MyList*)malloc(sizeof(MyList));
    myList->x1 = x1;
    myList->x0 = x0;
    myList->next = NULL;

    return myList;
    }
///*******************************************************************
MyList* MyListPrintNode(MyList* myList){
    if(NULL == myList) return NULL;
    printf("%d %d ", myList->x1, myList->x0);
    return myList;
    }
///*******************************************************************
MyList* MyListRand(int length, int a, int b){
    MyList *myList, *myWalk;
    myList = MyListNew(MyRand(a, b), MyRand(a, b));
    myWalk = myList;

    for(int i = 1; i<length; ++i){
        myWalk->next = MyListNew(MyRand(a, b), MyRand(a, b));
        myWalk = myWalk->next;
        }

    return myList;
    }
///*******************************************************************
///*******************************************************************
int MyRand(int a, int b){
    if(a>=b) return b;
    return rand()%(b-a) +a;
    }
///*******************************************************************
int MyRead(char* myStr){
    int x;
    if(NULL!=myStr) printf("%s", myStr);
    scanf("%d", &x);
    return x;
    }
///*******************************************************************
///*******************************************************************
int main(){
    srand(time(0));
    MyList* myL0, * myWalk;
    myL0 = MyListNew(MyRand(0,100), MyRand(0,100));
    myWalk = myL0;

    myWalk->next = MyListNew(MyRand(0,100), MyRand(0,100));
    myWalk = myWalk->next;
    myWalk->next = MyListNew(MyRand(0,100), MyRand(0,100));
    myWalk = myWalk->next;
    myWalk->next = MyListNew(MyRand(0,100), MyRand(0,100));
    myWalk = myWalk->next;
    myWalk->next = MyListNew(MyRand(0,100), MyRand(0,100));

    myWalk = myL0;

    MyListPrintNode(myWalk);
    myWalk = myWalk->next;

    MyListPrintNode(myWalk);
    myWalk = myWalk->next;

    MyListPrintNode(myWalk);
    myWalk = myWalk->next;

    MyListPrintNode(myWalk);
    myWalk = myWalk->next;

    MyListPrintNode(myWalk);
    myWalk = myWalk->next;

    return 0;
    }



