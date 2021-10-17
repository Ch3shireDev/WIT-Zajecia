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
    MyNode mN0, mN1, mN2, mN3, mN4;
    MyNode* myHead;

    myHead   = &mN0;
    myHead->next = &mN1;
    myHead->next->next = &mN2;
    myHead->next->next->next = &mN3;
    myHead->next->next->next->next = &mN4;
    myHead->next->next->next->next->next = NULL;


    myHead->x = 0;
    myHead->next->x = 1;
    myHead->next->next->x = 2;
    myHead->next->next->next->x = 3;
    myHead->next->next->next->next->x = 4;

    PrintNode(myHead,"x = ");
    PrintNode(myHead->next,"x = ");
    PrintNode(myHead->next->next,"x = ");
    PrintNode(myHead->next->next->next,"x = ");
    PrintNode(myHead->next->next->next->next,"x = ");


    return 0;
    }
