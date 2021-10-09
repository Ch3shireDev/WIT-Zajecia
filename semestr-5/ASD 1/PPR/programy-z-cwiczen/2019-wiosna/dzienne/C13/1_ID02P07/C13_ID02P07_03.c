#include<stdio.h>
#include<stdlib.h>
typedef struct LstTmp{
    int data;
    struct LstTmp* next;
    }MyList;
///*****************************************************
int main(){
    MyList mL0, mL1, mL2, mL3;
    MyList *pL0, *pL1, *pL2, *pL3;

    pL0 = &mL0;
    pL1 = &mL1;
    pL2 = &mL2;
    pL3 = &mL3;

    mL0.next = &mL1;
    mL1.next = &mL2;
    mL2.next = &mL3;
    mL3.next = NULL;

    mL0.data = 0;
    mL1.data = 1;
    mL2.data = 2;
    mL3.data = 3;

    printf("%d\n",mL0.data);
    printf("%d\n",mL1.data);
    printf("%d\n",mL2.data);
    printf("%d\n",mL3.data);
    printf("-------------------------------\n");
    printf("%d\n",pL0->data);
    printf("%d\n",pL0->next->data);
    printf("%d\n",pL0->next->next->data);
    printf("%d\n",pL0->next->next->next->data);



    return 0;
    }
