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
    printf("%s%3d\n",myStr, myNode->x);
/**    printf("%s%d\n",myStr, (*myNode).x); */
    return myNode;
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
    MyNode* myHead, *myWalk;
    int i,n;

    for(myHead=(MyNode*)malloc(sizeof(MyNode)),i=1,myWalk=myHead,n=MyRead("size ?=");
        n>i++;myWalk->next=(MyNode*)malloc(sizeof(MyNode)),
        myWalk=myWalk->next,myWalk->next=NULL);
    for(i=0,myWalk=myHead;myWalk;myWalk->x=i++,myWalk=myWalk->next);
    for(myWalk=myHead;myWalk;PrintNode(myWalk,"x = "),myWalk = myWalk->next);

    return 0;
    }
