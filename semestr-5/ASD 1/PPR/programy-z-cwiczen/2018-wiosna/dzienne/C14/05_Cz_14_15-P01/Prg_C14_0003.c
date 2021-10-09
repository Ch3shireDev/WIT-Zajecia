#include <stdio.h>
#include <stdlib.h>
/**************************************************************************/
/**************************************************************************/
typedef struct myBst{
    int x;
    struct myBst* left;
    struct myBst* right;
    }BST;
/**************************************************************************/
/**************************************************************************/
BST* NewBstNode(int);
BST* PrintBstNode(BST*, char*, char*, int);
BST* InsertBstNode(BST*, BST*);
/**************************************************************************/
/**************************************************************************/
int MyRead(char*);
/**************************************************************************/
/**************************************************************************/
BST* NewBstNode(int x){
    BST* bSt = (BST*)malloc(sizeof(BST)) ;
    bSt->x = x;
    bSt->left = bSt->right = NULL;
    return bSt;
    }
/**************************************************************************/
BST* PrintBstNode(BST* bSt, char* strB, char* strE, int x){
    if(!bSt)return NULL;
    printf("%s%*d%s",strB, x, bSt->x, strE);
    return bSt;
    }
/**************************************************************************/
BST* InsertBstNode(BST* rootBst, BST* newNode){
    if(!rootBst) return NULL;
    if(rootBst->x>=newNode->x)
        if(!rootBst->left) rootBst->left = newNode;
        else InsertBstNode(rootBst->left,newNode);
    else
        if(!rootBst->right) rootBst->right = newNode;
        else InsertBstNode(rootBst->right,newNode);
    return newNode;
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
    BST* rootBst;
    rootBst = NewBstNode(MyRead("root ?= "));
    InsertBstNode(rootBst, NewBstNode(MyRead("root ?= ")));
    InsertBstNode(rootBst, NewBstNode(MyRead("root ?= ")));

    PrintBstNode(rootBst->left,"\n l=","\n", 3);
    PrintBstNode(rootBst->right,"\n r=","\n", 3);

    return 0;
    }
















