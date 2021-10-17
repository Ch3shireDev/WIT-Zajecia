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
    MyNode mN0, mN1, mN2, mN3, mN4;
    MyNode* myH;



    myH = &mN0;
    myH->next = &mN1;
    myH->next->next = &mN2;
    myH->next->next->next = &mN3;
    myH->next->next->next->next = &mN4;
    myH->next->next->next->next->next = NULL;

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

    return 0;
    }















