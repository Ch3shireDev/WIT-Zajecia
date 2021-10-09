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
    myW->next->next = new MyNode;
    myW->next->next->next = new MyNode;
    myW->next->next->next->next = new MyNode;
    myW->next->next->next->next->next = NULL;

    myW = myH;

    myH->x = 0;
    myH->next->x = 1;
    myH->next->next->x = 2;
    myH->next->next->next->x = 3;
    myH->next->next->next->next->x = 4;


    cout<<"x = "<<myH->x<<endl;
    cout<<"x = "<<myH->next->x<<endl;
    cout<<"x = "<<myH->next->next->x<<endl;
    cout<<"x = "<<myH->next->next->next->x<<endl;
    cout<<"x = "<<myH->next->next->next->next->x<<endl;



    delete myH->next->next->next->next;
    delete myH->next->next->next;
    delete myH->next->next;
    delete myH->next;
    delete myH;

    return 0;
    }















