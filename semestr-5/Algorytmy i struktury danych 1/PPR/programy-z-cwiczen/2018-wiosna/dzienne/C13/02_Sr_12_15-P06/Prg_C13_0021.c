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
    return myNode;
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
    MyNode* myHead, *myWalk;
    int i;

    for(myHead = (MyNode*)malloc(sizeof(MyNode)),
        myWalk = myHead,i=0;i<15;
        myWalk->next = (MyNode*)malloc(sizeof(MyNode)),
        myWalk = myWalk->next,myWalk->next = NULL,++i);
    for(i=0,myWalk=myHead;myWalk;myWalk->x=i++,
        myWalk=myWalk->next);
    for(myWalk=myHead;myWalk;PrintMyNode(myWalk,"x = "),
        myWalk=myWalk->next);

    return 0;
    }














