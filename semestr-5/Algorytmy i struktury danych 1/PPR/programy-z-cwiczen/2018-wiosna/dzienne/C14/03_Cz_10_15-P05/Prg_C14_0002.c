#include<stdio.h>
#include<stdlib.h>
/***********************************************************/
/***********************************************************/
typedef struct MyBst{
    int x;
    struct MyBST* left;
    struct MyBST* right;
    }BST;
/***********************************************************/
/***********************************************************/
BST* NewNodeBST(int);
BST* PrintNodeBST(BST*);
BST* AddNodeBST(BST*, BST*);
/***********************************************************/
/***********************************************************/
int MyRead(char*);
/***********************************************************/
/***********************************************************/
BST* NewNodeBST(int x){
    BST * myBst = (BST*)malloc(sizeof(BST));
    myBst->x = x;
    myBst->left = NULL;
    myBst->right = NULL;
    return myBst;
    }
/***********************************************************/
BST* PrintNodeBST(BST* myBst){
    printf("x = %3d, node = %p, left = %p, right = %p\n",
           myBst->x, (void*)myBst,
           (void*)myBst->left, (void*)myBst->right);
    return myBst;
    }
/***********************************************************/
BST* AddNodeBST(BST* root, BST* node){
    if(NULL==root) return node;
    if(NULL==node) return root;
    if(node->x<=root->x){
        if(NULL==root->left) root->left=node;
        else AddNodeBST(root->left, node);
        }
    else{
        if(NULL==root->right) root->right=node;
        else AddNodeBST(root->right, node);
    }
    return root;
    }
/***********************************************************/
/***********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
/***********************************************************/
/***********************************************************/
int main(){
    PrintNodeBST(NewNodeBST(MyRead("x ?=")));

    return 0;
    }








