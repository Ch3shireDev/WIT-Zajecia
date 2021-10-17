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

    for(int i=1;i<5;++i){
        myW->next = new MyNode;
        myW = myW->next;
        }

    myW->next = NULL;

    myW = myH;


    for(int i=0;i<5;++i){
        myW->x = i;
        myW=myW->next;
        }

    myW = myH;

    cout<<"x = "<<myW->x<<endl;
    cout<<"x = "<<myW->next->x<<endl;
    cout<<"x = "<<myW->next->next->x<<endl;
    cout<<"x = "<<myW->next->next->next->x<<endl;
    cout<<"x = "<<myW->next->next->next->next->x<<endl;




    return 0;
    }















