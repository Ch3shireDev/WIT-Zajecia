#include <iostream>
using namespace std;
///*******************************************************************************
///*******************************************************************************
int MyRead(int);
int* NewTabInt01(unsigned);
int** NewTabInt02(unsigned, unsigned);
void FillTabInt02(int **,unsigned, unsigned);
void PrintTabInt02(int **,unsigned, unsigned);
void SwapColTabInt02(int **,unsigned, unsigned);
///*******************************************************************************
///*******************************************************************************
int MyRead(int i){
    int x;
    cout<<"x"<<i<<" ?=";
    cin>>x;

    return x;
    }
///*******************************************************************************
int* NewTabInt01(unsigned sT){
    return new int[sT];
    }
///*******************************************************************************
int** NewTabInt02(unsigned sT1, unsigned sT2){
    int** myT2;

    myT2=new int* [sT1];

    for(int i=0; i<sT1; ++i)
        myT2[i]=new int[sT2];

    return myT2;
    }
///*******************************************************************************
void FillTabInt02(int ** myT2,unsigned sT1, unsigned sT2){
    for(int i=0;i<sT1;++i)
        for(int j=0; j<sT2;++j){
            cout<<"T["<<i<<"]["<<j<<"]?=";
            cin>>myT2[i][j];
            }
    }
///*******************************************************************************
void PrintTabInt02(int ** myT2,unsigned sT1, unsigned sT2){
    for(int j=0; j<sT2;++j){
        for(int i=0;i<sT1;++i){
            cout<<"[";
            cout.width(3);
            cout<<myT2[i][j];
            cout<<"]";
            }
        cout<<endl;
        }
    }
///*******************************************************************************
void SwapColTabInt02(int ** myT2,unsigned c1, unsigned c2){
    int * tmp;

    tmp=myT2[c1];
    myT2[c1]=myT2[c2];
    myT2[c2]=tmp;

    }
///*******************************************************************************
///*******************************************************************************
int main(){
    int** myT2;
    unsigned sT1=4, sT2=3;

    myT2=NewTabInt02(sT1, sT2);
    FillTabInt02(myT2,sT1,sT2);
    PrintTabInt02(myT2,sT1,sT2);
    cout<<endl<<"******************************"<<endl;
    SwapColTabInt02(myT2,1,3);
    PrintTabInt02(myT2,sT1,sT2);


    /** 8b, 9b, 10b

      !     !
    0 1 2 3 4
    ---------
    1 9 2 2 5
    5 3 4 3 0
    2 1 6 3 4
    4 4 5 4 4


    1 5 2 2 9
    5 0 4 3 3
    2 4 6 3 1
    4 4 5 4 4




    */



    return 0;
    }
