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
    MyList mL00, mL01, mL02, mL03, mL04;
    MyList * myHead;

    myHead = &mL00;
/** mL00.next = &mL01;*/
    myHead->next = &mL01;
/** mL01.next = &mL02;*/
    mL00.next->next = &mL02;
/** mL02.next = &mL03;*/
    mL01.next->next = &mL03;
/** mL03.next = &mL04;*/
    mL02.next->next = &mL04;
/** mL04.next = NULL;*/
    mL03.next->next = NULL;

/**    mL00.x = 0;*/
    myHead->x = 0;
/**    mL01.x = 1;*/
    myHead->next->x = 1;
    myHead->next->next->x = 2;
    myHead->next->next->next->x = 3;
    myHead->next->next->next->next->x = 4;

    PrintMyList(&mL00,"mL00->x = ");
    PrintMyList(&mL01,"mL01->x = ");
    PrintMyList(&mL02,"mL02->x = ");
    PrintMyList(&mL03,"mL03->x = ");
    PrintMyList(&mL04,"mL04->x = ");




    return 0;
    }














