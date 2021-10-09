#include <iostream>
using namespace std;
///*******************************************************************************
///*******************************************************************************
void MyText();
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaSzczecinaiOkolic();
int MyRead();
///*******************************************************************************
///*******************************************************************************
void MyText(){
    KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaSzczecinaiOkolic();
    }
///*******************************************************************************
void KonstantynopolitanczykowianeczkazKonstantynopolaKrakowaSzczecinaiOkolic(){
    cout<<"Konstantynopolitanczykowianeczka";
    cout<<" z Konstantynopola Krakowa Szczecina i Okolic"<<endl;
    }
///*******************************************************************************
int MyRead(){
    int x;
    cout<<"x ?=";
    cin>>x;

    return x;
    }
///*******************************************************************************
///*******************************************************************************
int main(){
    int x;

    x =MyRead();
    cout<<"x = "<<x<<endl;

    return 0;
    }
