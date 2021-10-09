#include <stdio.h>
#include <stdlib.h>
/**************************************************************************************/
typedef struct MyL{
    int x;
    struct MyL* next;
    }MyList;
/**************************************************************************************/
/**************************************************************************************/
MyList* MyListNew(int);
void MyListIni(MyList*);
void MyListPrint(MyList*);
/**************************************************************************************/
/**************************************************************************************/
MyList* MyListNew(int cnt){
    MyList* head, *walk;
    head= (MyList*)malloc(sizeof(MyList));

    for(walk = head;--cnt;walk=walk->next)
        walk->next= (MyList*)malloc(sizeof(MyList));

    walk->next=NULL;
    return head;
    }
/**************************************************************************************/
void MyListIni(MyList* walk){
    int i;
    for(i=0;walk!=NULL;++i,walk=walk->next)
        walk->x=i;
    }
/**************************************************************************************/
void MyListPrint(MyList* walk){
    int i;
    for(i=0;walk!=NULL;++i,walk=walk->next)
        printf("mL0%d.x = %d\n",i, walk->x);;
    }
/**************************************************************************************/
/**************************************************************************************/
int main(){
    MyList* mL00;

    mL00=MyListNew(6);
    MyListIni(mL00);

    MyListPrint(mL00);
    return 0;
    }
