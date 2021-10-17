#include<stdio.h>
#include<stdlib.h>
typedef struct LstTmp{
    int data;
    struct LstTmp* next;
    }MyList;
///*****************************************************
int main(){
    MyList *pL0, *pL1, *pL2, *pL3;

    pL0 = (MyList*)malloc(sizeof(MyList));
    pL1 = (MyList*)malloc(sizeof(MyList));
    pL2 = (MyList*)malloc(sizeof(MyList));
    pL3 = (MyList*)malloc(sizeof(MyList));

    pL0->next = pL1;
    pL1->next = pL2;
    pL2->next = pL3;
    pL3->next = NULL;

    pL0->data = 0;
    pL1->data = 1;
    pL2->data = 2;
    pL3->data = 3;


    printf("-------------------------------\n");
    printf("%d\n",pL0->data);
    printf("%d\n",pL0->next->data);
    printf("%d\n",pL0->next->next->data);
    printf("%d\n",pL0->next->next->next->data);



    return 0;
    }
