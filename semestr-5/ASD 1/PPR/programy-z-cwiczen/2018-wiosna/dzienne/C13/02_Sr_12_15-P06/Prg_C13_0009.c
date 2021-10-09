#include <stdio.h>
#include <stdlib.h>
/**********************************************************************/
/**********************************************************************/
typedef struct MyN{
    int x;
    struct MyN* next;
    }MyNode;
/**********************************************************************/
/**********************************************************************/
MyNode* PrintMyNode(MyNode*, char*);
/**********************************************************************/
/**********************************************************************/
int MyRead(char*);
/*******************************************************************************/
/**********************************************************************/
MyNode* PrintMyNode(MyNode* myNode, char* myStr){
    if(myNode==NULL) return NULL;
    printf("%s%3d\n",myStr, myNode->x);
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
    MyNode mN0, mN1, mN2, mN3, mN4;
    MyNode* myHead;

    myHead = &mN0;
    (&mN0)->next = &mN1;
    (&mN0)->next->next = &mN2;
    (&mN0)->next->next->next = &mN3;
    (&mN0)->next->next->next->next = &mN4;
    (&mN0)->next->next->next->next->next = NULL;

    (&mN0)->x = 0;
    (&mN0)->next->x = 1;
    (&mN0)->next->next->x = 2;
    (&mN0)->next->next->next->x = 3;
    (&mN0)->next->next->next->next->x = 4;


    PrintMyNode(&mN0,"x = ");
    PrintMyNode((&mN0)->next,"x = ");
    PrintMyNode((&mN0)->next->next,"x = ");
    PrintMyNode((&mN0)->next->next->next,"x = ");
    PrintMyNode((&mN0)->next->next->next->next,"x = ");


    return 0;
    }














