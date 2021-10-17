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
    if(myNode==NULL)return NULL;
    printf("%s%3d\n", myStr, myNode->x);
    return myNode;
    }
/**************************************************************************/
MyNode* NewList(int n){
    MyNode * myHead, * myWalk;
    int i;
    if(n<1)return NULL;

    myHead = (MyNode*)malloc(sizeof(MyNode));
    myWalk = myHead;
    myWalk -> x =0;

    for(i=1; i<12;++i){
        myWalk->next = (MyNode*)malloc(sizeof(MyNode));
        myWalk = myWalk->next;
        myWalk -> x =0;
        }
    myWalk->next = NULL;

    return myHead;
    }
/**************************************************************************/
MyNode* IniList(MyNode* myHead, int a1, int r){
    MyNode * myWalk;
    if(myHead == NULL) return NULL;
    myWalk = myHead;
    myWalk->x = a1;
    for(; myWalk->next!=NULL; ){
        myWalk->next->x = myWalk->x+ r;
        myWalk = myWalk->next;
        }
    return myHead;
    }
/**************************************************************************/
MyNode* PrintList(MyNode* myHead, char* myStr){
    if(myHead==NULL) return NULL;
    PrintNode(myHead,myStr);
    for(; myHead->next!=NULL; ){
        PrintNode(myHead->next,myStr);
        myHead = myHead->next;
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
/**************************************************************************/
int main(){
    MyNode * myHead, * myWalk;
    int i;

    myHead = IniList(NewList(12), 2, 2);
    PrintList(myHead, "x = ")->next = IniList(NewList(12), 24, -2);
    PrintList(myHead, "\t\t new x = ");



    return 0;
    }
















