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


///**********************************************************************
///**********************************************************************
int main(){
    MyNode* myH, *myW;

    myH = new MyNode;

    myW = myH;

    myW->next = new MyNode;
    myW = myW->next;

    myW->next = new MyNode;
    myW = myW->next;

    myW->next = new MyNode;
    myW = myW->next;

    myW->next = new MyNode;
    myW = myW->next;

    myW->next = NULL;

    myW = myH;

    myW->x = 0;
    myW->next->x = 1;
    myW->next->next->x = 2;
    myW->next->next->next->x = 3;
    myW->next->next->next->next->x = 4;

    myW = myH;

    cout<<"x = "<<myW->x<<endl;
    cout<<"x = "<<myW->next->x<<endl;
    cout<<"x = "<<myW->next->next->x<<endl;
    cout<<"x = "<<myW->next->next->next->x<<endl;
    cout<<"x = "<<myW->next->next->next->next->x<<endl;




    return 0;
    }















