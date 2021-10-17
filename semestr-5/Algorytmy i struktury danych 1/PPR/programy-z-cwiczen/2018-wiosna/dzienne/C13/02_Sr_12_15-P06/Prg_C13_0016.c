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
    MyNode* myHead, *myWalk;
    int i;

    myHead = (MyNode*)malloc(sizeof(MyNode));
    myWalk = myHead;

    for(i=1;i<5;++i){
        myWalk->next = (MyNode*)malloc(sizeof(MyNode));
        myWalk = myWalk->next;
        }
    myWalk->next = NULL;

    myWalk = myHead;
    for(i=0;i<5;++i){
        myWalk->x = i;
        myWalk = myWalk->next;
        }


    myWalk = myHead;
    for(i=0;i<5;++i){
        PrintMyNode(myWalk,"x = ");
        myWalk = myWalk->next;
        }

    return 0;
    }














