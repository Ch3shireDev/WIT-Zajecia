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
int main(){
    MyNode* myH, *myW;

    myH = new MyNode;
    myW = myH;

    for(int i=1;i<15;++i){
        myW->next = new MyNode;
        myW = myW->next;
        }
    myW->next = NULL;

    myW = myH;
    for(int i=0;myW!=NULL;++i){
        myW->x = i;
        myW=myW->next;
        }

    myW = myH;
    while(myW!=NULL){
        cout<<"x = "<<myW->x<<endl;
        myW=myW->next;
        }
    return 0;
    }















