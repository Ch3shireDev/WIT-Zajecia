#include <iostream>
using namespace std;
///**********************************************************************
///**********************************************************************
struct MyNode{
    int x;
    MyNode* next;
    };
///**********************************************************************
///**********************************************************************
MyNode* NewList(int);
MyNode* FillList(MyNode*, int, int);
MyNode* PrintList(MyNode*);
///**********************************************************************
///**********************************************************************
MyNode* NewList(int n){
    MyNode* myH, *myW;

    myH = new MyNode;
    myW = myH;
    myW->x =0;
    for(int i=1;i<n;++i){
        myW->next = new MyNode;
        myW = myW->next;
        myW->x =0;
        }
    myW->next = NULL;

    return myH;
    }
///**********************************************************************
MyNode* FillList(MyNode* myH, int a1, int r){
    MyNode *myW;
    myW = myH;
    myW->x = a1;

    while(myW->next!=NULL){
        myW->next->x = myW->x+r;
        myW=myW->next;
        }
    return myH;
    }
///**********************************************************************
MyNode* PrintList(MyNode* myH){
    cout<<"x = "<<myH->x<<endl;
    while(myH->next!=NULL){
        myH=myH->next;
        cout<<"x = "<<myH->x<<endl;
        }
    return myH;
    }
///**********************************************************************
///**********************************************************************
int main(){
    MyNode* myH, *myW;

    myH = NewList(15);
    FillList(myH,1,1);
    PrintList(myH);

    return 0;
    }















