#include<stdio.h>
#include<stdlib.h>
///**************************************************************
typedef struct TmpList {
    int data;
    struct TmpList * next;
    }MyList;
///**************************************************************
///**************************************************************

///**************************************************************
///**************************************************************

int main(){
    MyList mL0, mL1, mL2, mL3;
    MyList *pL0;

    pL0 = (MyList*)malloc(sizeof(MyList));
    pL0->next = (MyList*)malloc(sizeof(MyList));
    pL0->next->next = (MyList*)malloc(sizeof(MyList));
    pL0->next->next->next = (MyList*)malloc(sizeof(MyList));
    pL0->next->next->next->next = NULL;

    pL0->data = 0;
    pL0->next->data = 1;
    pL0->next->next->data = 2;
    pL0->next->next->next->data = 3;


    printf("%d\n", pL0->data);
    printf("%d\n", pL0->next->data);
    printf("%d\n", pL0->next->next->data);
    printf("%d\n", pL0->next->next->next->data);
    printf("------------------------------------\n");

    return 0;
    }
