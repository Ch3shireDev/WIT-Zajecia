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
    MyList *pL0, *pL1, *pL2, *pL3;

    pL0 = &mL0;
    pL1 = &mL1;
    pL2 = &mL2;
    pL3 = &mL3;

    pL0->data = 0;
    pL1->data = 1;
    pL2->data = 2;
    pL3->data = 3;

    pL0->next = pL1;
    pL1->next = pL2;
    pL2->next = pL3;
    pL3->next = NULL;


    printf("%d\n", pL0->data);
    printf("%d\n", pL1->data);
    printf("%d\n", pL2->data);
    printf("%d\n", pL3->data);


    return 0;
    }
