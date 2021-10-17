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
    MyNode* myHead;

    myHead = (MyNode*)malloc(sizeof(MyNode));
    myHead->next = (MyNode*)malloc(sizeof(MyNode));
    myHead->next->next = (MyNode*)malloc(sizeof(MyNode));
    myHead->next->next->next = (MyNode*)malloc(sizeof(MyNode));
    myHead->next->next->next->next = (MyNode*)malloc(sizeof(MyNode));
    myHead->next->next->next->next->next = NULL;

    myHead->x = 0;
    myHead->next->x = 1;
    myHead->next->next->x = 2;
    myHead->next->next->next->x = 3;
    myHead->next->next->next->next->x = 4;


    PrintMyNode(myHead,"x = ");
    PrintMyNode(myHead->next,"x = ");
    PrintMyNode(myHead->next->next,"x = ");
    PrintMyNode(myHead->next->next->next,"x = ");
    PrintMyNode(myHead->next->next->next->next,"x = ");


    return 0;
    }














