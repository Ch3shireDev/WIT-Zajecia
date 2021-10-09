#include <stdio.h>
#include <stdlib.h>
/**************************************************************************/
/**************************************************************************/
typedef struct MyN{
    int x;
    struct MyN* next;
    }MyNode;
/**************************************************************************/
/**************************************************************************/
MyNode* PrintNode(MyNode*, char*);
/**************************************************************************/
/**************************************************************************/
int MyRead(char*);
/**************************************************************************/
/**************************************************************************/
MyNode* PrintNode(MyNode* myNode, char* myStr){
    if(myNode == NULL) return NULL;
    printf("%s%d\n",myStr, myNode->x);
/**    printf("%s%d\n",myStr, (*myNode).x); */
    return myNode;
    }
/**************************************************************************/
/**************************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s");
    scanf("%d", &x);
    return x;
    }
/**************************************************************************/
/**************************************************************************/
int main(){
    MyNode* myHead, *myWalk;

    myHead   = (MyNode*)malloc(sizeof(MyNode));
    myWalk = myHead;
    myWalk->next = (MyNode*)malloc(sizeof(MyNode));
    myWalk->next->next = (MyNode*)malloc(sizeof(MyNode));
    myWalk->next->next->next = (MyNode*)malloc(sizeof(MyNode));
    myWalk->next->next->next->next = (MyNode*)malloc(sizeof(MyNode));
    myWalk->next->next->next->next->next = NULL;


    myWalk = myHead;
    myWalk->x = 0;
    myWalk->next->x = 1;
    myWalk->next->next->x = 2;
    myWalk->next->next->next->x = 3;
    myWalk->next->next->next->next->x = 4;

    myWalk = myHead;
    PrintNode(myWalk,"x = ");
    PrintNode(myWalk->next,"x = ");
    PrintNode(myWalk->next->next,"x = ");
    PrintNode(myWalk->next->next->next,"x = ");
    PrintNode(myWalk->next->next->next->next,"x = ");


    return 0;
    }
