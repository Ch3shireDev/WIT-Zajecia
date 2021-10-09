#include <stdio.h>
#include <stdlib.h>
/*****************************************************************/
/*****************************************************************/
typedef struct MyBst{
    int x;
    struct MyBst* left;
    struct MyBst* right;
    }BST;
/*****************************************************************/
/*****************************************************************/
BST* NewNodeBST(int);
BST* AddNodeBST(BST*, BST*);
/*****************************************************************/
/*****************************************************************/
int MyRead(char*);
/*****************************************************************/
/*****************************************************************/
BST* NewNodeBST(int x){
    BST* bst;
    bst = (BST*)malloc(sizeof(BST));
    bst->x = x;
    bst->left = NULL;
    bst->right = NULL;

    return bst;
    }
/*****************************************************************/
BST* AddNodeBST(BST* bst, BST* node){
    if(NULL==bst) return node;
    if(NULL==node) return bst;

    if(bst->x>node->x){
        if(NULL!=bst->left) AddNodeBST(bst->left,node);
        else bst->left = node;
        }
    else{
        if(NULL!=bst->right) AddNodeBST(bst->right,node);
        else bst->right = node;
        }
    return bst;
    }
/*****************************************************************/
/*****************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
    scanf("%d",&x);
    return x;
    }
/*****************************************************************/
/*****************************************************************/
int main(){
    printf("BST->x = %d\n",NewNodeBST(MyRead("n ?="))->x);

    return 0;
    }















