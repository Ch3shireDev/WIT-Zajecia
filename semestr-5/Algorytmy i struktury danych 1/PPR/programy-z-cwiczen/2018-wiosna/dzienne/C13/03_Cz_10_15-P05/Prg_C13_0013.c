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
MyNode* NewList(int);
MyNode* IniList(MyNode*, int, int);
MyNode* PrintList(MyNode*, char*);
/**************************************************************************/
/**************************************************************************/
int MyRead(char*);
/**************************************************************************/
/**************************************************************************/
MyNode* PrintNode(MyNode* myNode, char* myStr){
    if(myNode == NULL) return NULL;
    printf("%s%3d\n",myStr, myNode->x);
/**    printf("%s%d\n",myStr, (*myNode).x); */
    return myNode;
    }
/**************************************************************************/
MyNode* NewList(int n){
    MyNode* myHead, *myWalk;
    int i;
    myHead   = (MyNode*)malloc(sizeof(MyNode));
    myWalk = myHead;
    for(i=1; i<n; ++i){
        myWalk->next = (MyNode*)malloc(sizeof(MyNode));
        myWalk = myWalk->next;
        }
    myWalk->next = NULL;
    return myHead;
    }
/**************************************************************************/
MyNode* IniList(MyNode* myHead, int a1, int r){
    MyNode *myWalk;
    if(myHead==NULL) return NULL;
    myWalk = myHead;
    myWalk->x = a1;
    for(; myWalk->next !=NULL;){
        myWalk->next->x = myWalk->x + r;
        myWalk = myWalk->next;
        }
    return myHead;
    }
/**************************************************************************/
/**************************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d", &x);
    return x;
    }
/**************************************************************************/
MyNode* PrintList(MyNode* myHead, char* myStr){

    if(myHead==NULL) return NULL;
    PrintNode(myHead, myStr);

    for(; myHead->next !=NULL;){
        PrintNode(myHead->next, myStr);
        myHead = myHead->next;
        }
    return myHead;
    }
/**************************************************************************/
/**************************************************************************/
int main(){
    MyNode* myHead, *myWalk;
    int i;

    myHead   = NewList(15);
    IniList(myHead,2,2);
    PrintList(myHead,"x = ");


    return 0;
    }
