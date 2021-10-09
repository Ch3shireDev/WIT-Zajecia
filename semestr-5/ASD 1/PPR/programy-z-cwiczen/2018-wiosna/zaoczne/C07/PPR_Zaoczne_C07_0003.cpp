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

    mN0.x = 0;
    mN1.x = 1;
    mN2.x = 2;
    mN3.x = 3;
    mN4.x = 4;

    cout<<"x = "<<mN0.x<<endl;
    cout<<"x = "<<mN1.x<<endl;
    cout<<"x = "<<mN2.x<<endl;
    cout<<"x = "<<mN3.x<<endl;
    cout<<"x = "<<mN4.x<<endl;
    cout<<"**********************************"<<endl;
    cout<<"x = "<<myH->x<<endl;
    cout<<"x = "<<myH->next->x<<endl;
    cout<<"x = "<<myH->next->next->x<<endl;
    cout<<"x = "<<myH->next->next->next->x<<endl;
    cout<<"x = "<<myH->next->next->next->next->x<<endl;

    return 0;
    }















