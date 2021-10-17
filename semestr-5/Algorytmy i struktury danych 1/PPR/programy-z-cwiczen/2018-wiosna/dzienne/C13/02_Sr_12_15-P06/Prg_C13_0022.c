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
MyNode* NewMyList(int);
MyNode* FillMyList(MyNode*, int, int);
MyNode* PrintMyNode(MyNode*, char*);
MyNode* PrintMyList(MyNode*, char*);
/**********************************************************************/
/**********************************************************************/
int MyRead(char*);
/**********************************************************************/
/**********************************************************************/
MyNode* NewMyList(int n){
    MyNode* myHead, *myWalk;
    int i;

    myHead = (MyNode*)malloc(sizeof(MyNode));
    myWalk = myHead;
    myWalk->x=0;
    for(i=1;i<n;++i){
        myWalk->next = (MyNode*)malloc(sizeof(MyNode));
        myWalk = myWalk->next;
        myWalk->x=0;
        }
    myWalk->next = NULL;

    return myHead;
    }
/**********************************************************************/
MyNode* FillMyList(MyNode* myHead, int a1, int r){
    MyNode *myWalk;

    if(myHead==NULL) return  NULL;

    myHead->x =a1;
    myWalk = myHead;

    while(myWalk->next){
        myWalk->next->x = myWalk->x+r;
        myWalk = myWalk->next;
        }
    return myHead;
    }
/**********************************************************************/
MyNode* PrintMyNode(MyNode* myNode, char* myStr){
    if(myNode==NULL) return NULL;
    printf("%s%3d\n",myStr, myNode->x);
    return myNode;
    }
/**********************************************************************/
MyNode* PrintMyList(MyNode* myHead, char* myStr){
    if(myHead==NULL) return  NULL;
    PrintMyNode(myHead, myStr);
    while(myHead->next){
        myHead = myHead->next;
        PrintMyNode(myHead, myStr);
        }
    return myHead;
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

    /**
    myHead = NewMyList(15);
    FillMyList(myHead, 2,2);
    */
    myHead = FillMyList(NewMyList(MyRead("size ?=")),2,2);
    PrintMyList(myHead, "x = ")->next = FillMyList(NewMyList(MyRead("size ?=")),22,-2);
    PrintMyList(myHead, "x = ");

    return 0;
    }














